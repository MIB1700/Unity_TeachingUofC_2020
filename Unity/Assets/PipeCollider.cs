using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using extOSC;


public class PipeCollider : MonoBehaviour
{

    public int pipeID = 0;

    public OSCTransmitter oscTransmitter;
    public string address = "/Pipe";

    public PipeCollider otherSide;

    public bool blocked = false;
    public float blockedTime = 1f;

    private void OnTriggerEnter(Collider other)
    {
        //need to be able to detect which side we collided with
        //whatever we hit first, block the other side, then unblock after some time...
        if (other.gameObject.CompareTag("Player") && !blocked)
        {
            OSCsend(pipeID);

            //now we can trigger the other side's collider
            otherSide.blocked = true;

            Invoke("Unblock", blockedTime);
        }
    }

    private void Unblock()
    {
        //both colliders should be ok to go now
        otherSide.blocked = false;
    }

    private void OSCsend(int ID)
    {
        Debug.Log($"portal: {ID}");

        var message = OSCMessage.Create(address);

        message.AddValue(OSCValue.Int(ID));

        oscTransmitter.Send(message);
    }
}
