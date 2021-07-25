using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    
    private const string HORIZONTAL = "Horizontal";
    private const string VERTICAL = "Vertical";

    private float horizontalInput;
    private float verticalInput;
    private float currentBreakForce;
    private bool isBreaking;

    [SerializeField] private WheelCollider frontLeftWheelCollider;
    [SerializeField] private WheelCollider frontRighttWheelCollider;
    [SerializeField] private WheelCollider RearLeftWheelCollider;
    [SerializeField] private WheelCollider RearRightWheelCollider;

    [SerializeField] private float motorForce;
    [SerializeField] private float breakForce;

    private void FixedUpdate() 
    {
        GetInput();
        HandleMotor();
        HandleSteering();
        UpdateWheels();
    }

    private void GetInput()
    {
        horizontalInput = Input.GetAxis(HORIZONTAL);
        verticalInput = Input.GetAxis(VERTICAL);
        isBreaking = Input.GetKey(KeyCode.Space);
    }

    private void HandleMotor()
    {
        // frontLeftWheelCollider.motorTorque = verticalInput * motorForce;
        // frontRighttWheelCollider.motorTorque = verticalInput * motorTorque;
        currentBreakForce = isBreaking ? breakForce : 0f;

        if (isBreaking)
        {
            ApplyBreak();
        }
    }

    private void ApplyBreak()
    {
        

    }

    private void HandleSteering()
    {

    }

    private void UpdateWheels()
    {

    }
}
