using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Following : MonoBehaviour
{


    Vector3 offset = Vector3.one * 4f;

    // Start is called before the first frame update
    void Start()
    {
        Moving.HasChangedPosition += RedCubeHasMoved;
    }

    void RedCubeHasMoved(Vector3 position)
    {

        Debug.Log(position);

        transform.position = Vector3.MoveTowards(transform.position, position + offset, 10f);

    }


    //is called when the object is destroyed
    private void OnDestroy()
    {
        Moving.HasChangedPosition -= RedCubeHasMoved;
    }

}
