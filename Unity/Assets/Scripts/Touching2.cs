using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using extOSC;

public class Touching2 : MonoBehaviour
{
    [Header("Unity Components")]
    public AudioSource audioSource;
    public MeshRenderer meshRenderer;
    public Material[] materials;

    [Header("OSC Settings")]
    public OSCReceiver oscReceiver;
    public OSCTransmitter oscTransmitter;

    public string address = "/Player";
    public string sendAddress = "/Max";

    private bool oscReceived = false;
/*********************************************************/
    // Start is called before the first frame update
    void Start()
    {
        if (TryGetComponent<AudioSource>(out audioSource))
        {
            //if AudioSource is found, init with some default values
            audioSource.pitch = 1f;
            audioSource.volume = 1.0f;
            audioSource.dopplerLevel = 2f;
            audioSource.loop = false;

            audioSource.Stop();
        }
        else
        {
            Debug.LogError("No audio source found!!!");
        }

        if (TryGetComponent<MeshRenderer>(out meshRenderer))
        {
            //make sure we start with the material we want to
            meshRenderer.material = materials[0];
        }

        //bind the OSC address to the callbackfunction "ReceivedMessage"
        oscReceiver.Bind(address, ReceivedMessage);
    }
/*********************************************************/
    //callback for OSC messages
    private void ReceivedMessage(OSCMessage message)
    {
        if (message.ToInt(out int value))
        {
            if (value <= 1 && value >= 0)
            {
                Debug.Log($"value is {value}");

                oscReceived = true;

                meshRenderer.material = materials[value];
                meshRenderer.UpdateGIMaterials();
            }
        }
    }
/*********************************************************/
    //send OSC message 
    private void Send(string address, OSCValue value)
    {
        var message = new OSCMessage(address, value);

        oscTransmitter.Send(message);
    }
/*********************************************************/
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            //send string "bumped" when player touches this gameObject
            Send(sendAddress, OSCValue.String("bumped"));

            if (audioSource.isPlaying)
            {
                //while audio is playing, ignore any touches
            }
            else
            {
                Debug.Log("Moving Cube touched us...");

                audioSource.pitch = Random.Range(0.75f, 2f); //randomize pitch
                audioSource.Play();

                meshRenderer.material = materials[1]; //change Material

                oscReceived = false;
            }

        }

    }
/*********************************************************/
    private void Update()
    {
        //when audio is done playing, reset to red material
        if (!audioSource.isPlaying && oscReceived == false)
        {
            meshRenderer.material = materials[0];
        }

        /* this is where the bug happened. since we weren't playing
         * a sound, the material was set back to red (i.e. materials[0]
         * in the very next frame.
         * My fix (for now):
         *  set a bool to true when a OSC message was received therefore
         *  circumventing the above if statement. When the player touches
         *  the sphere or cube again, set the bool to false... 
         */
    }
/*********************************************************/
}
