using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputModule : MonoBehaviour
{

    [SerializeField] private float moveSpeed;
    private MovementModule _movementModule;
   
    void Start()
    {
        _movementModule = GetComponent <MovementModule>();
    }
    void Update()
    {
        MovementInput();
    }
    private void MovementInput()
    {
        float vertical = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float horizontal = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        _movementModule.Move(new Vector3(horizontal, 0f, vertical));
    }
}
