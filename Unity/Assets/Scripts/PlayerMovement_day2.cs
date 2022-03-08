using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MR.CustomExtensions;

public class PlayerMovement_day2 : MonoBehaviour
{
    [Header("Required Components")]
    [SerializeField]
    private CharacterController controller;

    [SerializeField]
    private Transform cam;

    [Header("User Settings")]
    [SerializeField]
    private float speed = 6f;

    [SerializeField]
    private float turnSmoothTime = 0.1f;

/**************************************************************************/
    float turnSmoothVelocity;

    Vector3 moveDirection;

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
    }
    /**************************************************************************/


    // Update is called once per frame
    void Update()
    {
        //arrow keys AND wsad
        float horizontal = Input.GetAxisRaw("Horizontal"); //between -1 and 1
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
        //use normalized to avoid speeding up when using two buttons at the same 


        //check that we are actually moving before doing any work
        if (direction.magnitude >= 0.1f)
        {
            //figure out angle between player and where we want to look
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;

            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);

            //rotate gameObject to this angle
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            //move towards (i.e. forward) the target Angle
            moveDirection = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;

            //now move the player
            controller.Move(moveDirection.normalized * speed * Time.deltaTime);
        }
    }
}
