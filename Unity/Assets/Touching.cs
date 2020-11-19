using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touching : MonoBehaviour
{

    public AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("MovingCube"))
        {

            Debug.Log("Moving Cube touched us...");

            audioSource.pitch = Random.Range(0.75f, 2f);
            audioSource.volume = 0.75f;
            audioSource.dopplerLevel = 2f;

            audioSource.loop = true;

            audioSource.Play();

        }

    }

}
