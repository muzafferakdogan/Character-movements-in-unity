using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceModule : MonoBehaviour
{

    [SerializeField] private Transform[] target;
    private Vector3 dir;
    int i = 0;
    

    private MovementModule _movementModule;

    void Start()
    {
        _movementModule = GetComponent<MovementModule>();   

    }
    
    void Update()
    {
        if (Vector3.Distance(target[i].position, transform.position)>0.6f)
        {
            Rotate();
        }
        else
        {
            i++;
            Rotate();
        }
                 
        
    }
    private void Rotate()
    {
        Vector3 dir = target[i].position - transform.position;
        _movementModule.Move(dir);
        print(Vector3.Distance(target[i].position, transform.position));
    }
}
