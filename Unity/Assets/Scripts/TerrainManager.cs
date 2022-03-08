using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using extOSC;

public class TerrainManager : MonoBehaviour
{
    public GameObject player;

    [SerializeField]
    private GameObject[] terrainObjects;

    [SerializeField]
    private GameObject[] nClosests;
    public int closests = 4;

    public OSCTransmitter oscTransmitter;
    public string address = "/distances";
/********************************************************/
    // Start is called before the first frame update
    void Start()
    {

        terrainObjects = GameObject.FindGameObjectsWithTag("terrain");


        InvokeRepeating("SendOSC", 0f, 0.5f);

    }
/********************************************************/
    // Update is called once per frame
    void Update()
    {
        //take position of the player; compare to all terrainObjects...

        nClosests = terrainObjects.OrderBy(t => (t.transform.position - player.transform.position).sqrMagnitude)
                                  .Take(closests)
                                  .ToArray();
      
    }
/********************************************************/
    void SendOSC()
    {
        //Debug.Log("SendOSC");

        var message = OSCMessage.Create(address);


        foreach (var item in nClosests)
        {
            float dist = (item.transform.position - player.transform.position).magnitude;

            message.AddValue(OSCValue.Float(dist));
        }

        oscTransmitter.Send(message);
    }
}
