using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceToPointInCircle : MonoBehaviour
{

    [SerializeField] private Transform[] target;
    [SerializeField] private Transform[] circlePointOfTheTarget;
    [SerializeField] private float circleRadius;

    private Vector3 dir;
    private int _pointNumber = 0;
    private MovementModule _movementModule2;

    void Start()
    {
        _movementModule2 = GetComponent<MovementModule>();
        CreatPointAroundTheTarget();
    }

    void Update()
    {
        if (Vector3.Distance(circlePointOfTheTarget[_pointNumber].position, transform.position) > 0.6f)
        {
            MoveToTarget();
        }
        else
        {
            _pointNumber++;
            RestToPointsIndex();
            MoveToTarget();
        }
    }

    private void MoveToTarget()
    {
        Vector3 dir = circlePointOfTheTarget[_pointNumber].position - transform.position;
        _movementModule2.Move(dir);
    }

    private void RestToPointsIndex()
    {
        if (_pointNumber == circlePointOfTheTarget.Length)
        {
            _pointNumber = 0;
            for (int i = 0; i < target.Length; i++)
            {
                circlePointOfTheTarget[i].position = target[i].position;
            }
            CreatPointAroundTheTarget();
        }
    }

    private void CreatPointAroundTheTarget()
    {
        for (int i = 0; i < target.Length; i++)
        {
            circlePointOfTheTarget[i].position += (Vector3)Random.insideUnitCircle * circleRadius;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(Vector3.zero, circleRadius);
    }
}