using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    private void Start()
    {
        
    }

    private void Update()
    {
        Moove();
    }

    public void Moove()
    {
        float moveZ = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;

        transform.position += new Vector3(moveX, 0, moveZ).normalized;
    }

}
