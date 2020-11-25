using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touching : MonoBehaviour
{
    public AudioSource audioSource;
    public MeshRenderer meshRenderer;
    public Material[] materials;


    // Start is called before the first frame update
    void Start()
    {
        audioSource.pitch = 1f;
        audioSource.volume = 1.0f;
        audioSource.dopplerLevel = 2f;
        audioSource.loop = false;
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {

            Debug.Log("Moving Cube touched us...");

            audioSource.pitch = Random.Range(0.75f, 2f);
            audioSource.Play();
        }

    }


    private void Update()
    {
        if (!audioSource.isPlaying)
        {
            meshRenderer.material = materials[0];
        }
    }
}
