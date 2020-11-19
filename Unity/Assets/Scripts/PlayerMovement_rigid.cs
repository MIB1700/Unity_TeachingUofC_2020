using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement_rigid : MonoBehaviour
{

    [SerializeField]
    private Rigidbody rb;

    [SerializeField]
    private float speed = 6f;

    [SerializeField]
    private Transform cam;

    [SerializeField]
    private float turnSmoothTime = 0.1f;

    float turnSmoothVelocity;

    Vector3 moveDirection;

    private float jumpHeight = 20.0f;
    private float gravityValue = -9.81f;

    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.TryGetComponent<Rigidbody>(out rb))
        {
            //if there is a component of type CharacterController... assign to
            //private variable "controller"
        }
        else
        {
            //if we forgot to add it to the gameObject... add it now and assign
            //to variable "controller
            rb = gameObject.AddComponent<Rigidbody>();
        }
    }

    // Update is called once per frame
    void Update()
    {

        float horizontal = Input.GetAxisRaw("Horizontal"); //between -1 and 1
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;


        // Changes the height position of the player..
        if (Input.GetButtonDown("Jump"))
        {
            direction.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }


        //check that we are actually moving before doing any work
        if (direction.magnitude >= 0.1f)
        {
            //figure out angle between player and where we want to look
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;

            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);

            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            moveDirection = Quaternion.Euler(0f, targetAngle, 0f) * direction;

            rb.velocity = moveDirection.normalized * speed * Time.deltaTime;

        }

        //rb.velocity = new Vector3(horizontal * speed, 0, vertical * speed) * Time.deltaTime;
    }
}
