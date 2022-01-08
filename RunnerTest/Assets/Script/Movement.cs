using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed = 10;
    [SerializeField] float fieldSize = 4f;
    [SerializeField] InputAction movement;

    void Update()
    {
        ProcessInput();

    }

    void OnEnable() 
    {
        movement.Enable();
    }

    void OnDisable() 
    {
        movement.Disable();
    }

    void ProcessInput()
    {
        float xPos  = movement.ReadValue<Vector2>().x;
        float offset = xPos * speed * Time.deltaTime;
        float rawMovement = transform.localPosition.x + offset;
        float newMovement = Mathf.Clamp(rawMovement, -fieldSize, fieldSize);

        transform.localPosition = new Vector3(newMovement,transform.localPosition.y,transform.localPosition.z);        
    }

}
