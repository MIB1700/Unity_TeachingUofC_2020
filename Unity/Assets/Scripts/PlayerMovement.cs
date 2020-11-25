using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MR.CustomExtensions;
using extOSC;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private CharacterController controller;

    [SerializeField]
    private Transform cam;

    [SerializeField]
    private float speed = 6f;

    [SerializeField]
    private float turnSmoothTime = 0.1f;

    private float verticalOSC = 0f;
    private float horizontalOSC = 0f;
    /**************************************************************************/
    float turnSmoothVelocity;

    Vector3 moveDirection;

    [Header("OSC Settings")]
    public string Address = "/example/1";

    public OSCReceiver Receiver;
    public bool useOSC = false;

    /**************************************************************************/
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.TryGetComponent<CharacterController>(out controller))
        {
            //if there is a component of type CharacterController... assign to
            //private variable "controller"
        }
        else
        {
            //if we forgot to add it to the gameObject... add it now and assign
            //to variable "controller
            controller = gameObject.AddComponent<CharacterController>();

            controller.slopeLimit = 0f;
            controller.stepOffset = 0f;
            controller.center = controller.center.WithY(0.24f);
            controller.radius = 0.46f;
            controller.height = 0f;

            gameObject.transform.localScale = new Vector3(1.25f, 1.25f, 1.25f);
        }

        GameObject go = GameObject.FindGameObjectWithTag("OSCManager");

        Debug.Log(go.tag);

        if (go.TryGetComponent<OSCReceiver>(out Receiver))
        {
            Debug.Log("OSC Receiver found...");
        }
        else
        {
            Debug.LogError("OSC Receiver NOT FOUND!!!");
        }

        Receiver.Bind(Address, ReceivedMessage);
    }
    /**************************************************************************/

    private void ReceivedMessage(OSCMessage message)
    {
        if (message.ToVector2(out var value))
        {
            Debug.Log("VECTOR 2");

            horizontalOSC = value.x;
            verticalOSC = value.y;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //arrow keys AND wsad
        float horizontal = Input.GetAxisRaw("Horizontal"); //between -1 and 1
        float vertical = Input.GetAxisRaw("Vertical");

        if (useOSC)
        {
            vertical += verticalOSC;
            horizontal += horizontalOSC;
        }

        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
        //use normalized to avoid speeding up when using two buttons at the same 


        //check that we are actually moving before doing any work
        if (direction.magnitude >= 0.1f)
        {
            if (!useOSC)
            {
                //figure out angle between player and where we want to look
                float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;

                float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);

                //rotate gameObject to this angle
                transform.rotation = Quaternion.Euler(0f, angle, 0f);

                //move towards (i.e. forward) the target Angle
                moveDirection = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            }
            else
            {
                moveDirection = direction;
            }

            //now move the player
            controller.Move(moveDirection.normalized * speed * Time.deltaTime);
        }
    }
}
