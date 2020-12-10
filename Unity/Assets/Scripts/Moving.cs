using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Moving : MonoBehaviour
{

    public static event Action<Vector3> HasChangedPosition;
    


    // Update is called once per frame
    void Update()
    {

        HasChangedPosition(transform.position);
        
    }
}
