using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementModule : MonoBehaviour
{
    void Start()
    {
       
    }

    void Update()
    {
        
    }

    public void Move(Vector3 dir)
    {

        transform.position += dir.normalized;

        
    }
}
