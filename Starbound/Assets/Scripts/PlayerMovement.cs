using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private const float Y_AXIS_MOVEMENT = 0.0f;

    private const string HORIZONTAL_AXIS = "Horizontal";
    private const string VERTICAL_AXIS = "Vertical";

    [SerializeField]
    private float movementSpeed = 5.0f;


    void Start()
    {
        
    }

    void Update()
    {
        float HorizontalInput = Input.GetAxis(HORIZONTAL_AXIS);
        float VerticalInput = Input.GetAxis(VERTICAL_AXIS);

        Vector3 MovementDirection = new Vector3(HorizontalInput, Y_AXIS_MOVEMENT, VerticalInput);
        MovementDirection.Normalize();

        transform.Translate(MovementDirection * movementSpeed * Time.deltaTime, Space.World);
    }
}
