using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MR.CustomExtensions;
using System.Linq;
using extOSC;
using UnityEditor;


public class TerrainController : MonoBehaviour
{


    [SerializeField]
    private int closests = 3;

    [SerializeField]
    private GameObject[] terrainObjects;

    [SerializeField]
    private Transform player;

    [SerializeField]
    private GameObject[] nClosests;


    [Header("OSC Settings")]
    public OSCTransmitter Transmitter;
    public string _address = "/example/12/";


    // Start is called before the first frame update
    void Start()
    {
        EditorApplication.playModeStateChanged += LogPlayModeState;

        terrainObjects = GameObject.FindGameObjectsWithTag("terrain");

        //terrainObjects.ForEach<GameObject>(t =>
        //    {
        //        StartCoroutine(t.MoveToLocal(

        //                   t.transform.position.AddX(-3),  //to random location
        //                   5f,
        //                   UnityEngine.Random.Range(0f, 5f)//over random time
        //               )
        //       );
        //    }
        //);


        InvokeRepeating("SendOSC", 0f, 1f);
    }

    //using UnityEditor;

    //put in GameManager!!
    private void LogPlayModeState(PlayModeStateChange state)
    {
        var message = OSCMessage.Create("/Unity/state");

        switch (state)
        {
            case PlayModeStateChange.EnteredPlayMode:
                message.AddValue(OSCValue.String("Play"));
                break;
            case PlayModeStateChange.ExitingPlayMode:
                message.AddValue(OSCValue.String("Stop"));
                break;
            default:
                break;
        }


        Transmitter.Send(message);
    }



        // Update is called once per frame
    void Update()
    {
        //get 3 closest characters (to referencePos)
        nClosests = terrainObjects.OrderBy(t => (t.transform.position - player.position).sqrMagnitude)
                                   .Take(closests)   //or use .FirstOrDefault();  if you need just one
                                   .ToArray();
    }

    void SendOSC()
    {

        // Create message
        var message = OSCMessage.Create(_address);


        foreach (var item in nClosests)
        {
            float dist = (item.transform.position - player.position).magnitude;
            message.AddValue(OSCValue.Float(dist));
        }

        // Send message
        Transmitter.Send(message);

    }
}