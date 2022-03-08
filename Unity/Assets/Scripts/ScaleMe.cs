using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleMe : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        gameObject.transform.position = Vector3.zero; //new Vector3(0, 0, 0);
        
        gameObject.transform.localScale = new Vector3(1, 2, 3);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
