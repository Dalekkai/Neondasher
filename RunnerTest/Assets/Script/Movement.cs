using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed = 10;
    [SerializeField] float fieldSize = 4f;

    void Update()
    {
        ProcessInput();

    }

    void ProcessInput()
    {
        float movement = Input.GetAxis("Horizontal");
        float offset = movement * speed * Time.deltaTime;
        float rawMovement = transform.localPosition.x + offset;
        float newMovement = Mathf.Clamp(rawMovement, -fieldSize, fieldSize);

        transform.localPosition = new Vector3(newMovement,transform.localPosition.y,transform.localPosition.z);        
    }
}
