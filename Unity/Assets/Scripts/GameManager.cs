using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using extOSC;
using UnityEditor; //to have access to the playModeStateChanged callback

public class GameManager : MonoBehaviour
{

    public OSCTransmitter oscTransmitter;
    public string address = "/Unity/state";

/***************************************************************/
    // Start is called before the first frame update
    void Start()
    {

        EditorApplication.playModeStateChanged += PlayModeChanged;

    }
/***************************************************************/
    void PlayModeChanged(PlayModeStateChange state)
    {

        switch (state)
        {
            case PlayModeStateChange.EnteredPlayMode:
                OSCsend("Play");
                //Debug.Log("Entered Play");
                break;
            case PlayModeStateChange.ExitingPlayMode:
                OSCsend("Stop");
                //Debug.Log("Exit Play");
                break;
        }
    }
/***************************************************************/
    void OSCsend(string state)
    {   //create a message bound to the address
        var message = OSCMessage.Create(address);

        //add data to the message
        message.AddValue(OSCValue.String(state));

        //send the message through the Transmitter component
        oscTransmitter.Send(message);
    }
/***************************************************************/
}
