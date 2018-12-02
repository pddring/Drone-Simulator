using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour {
    Rigidbody rb;
    public Controller controller;
    public float ThrustScaler = 1;
    public float YawScaler = 1;
    public float PitchScaler = 1;
    public float RollScaler = 1;

    public Transform prop1;
    public Transform prop2;
    public Transform prop3;
    public Transform prop4;

    public float PropSpeed = 1;


    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
    
	}
	
	void FixedUpdate () {
        rb.AddForce(transform.up * ThrustScaler * controller.GetJoystick(Controller.Side.Left, Controller.Direction.Vertical ));
        rb.AddTorque(transform.up * YawScaler * controller.GetJoystick(Controller.Side.Left, Controller.Direction.Horizontal));
        rb.transform.Rotate(transform.right,  PitchScaler * controller.GetJoystick(Controller.Side.Right, Controller.Direction.Vertical));
        rb.transform.Rotate(transform.forward, -RollScaler * controller.GetJoystick(Controller.Side.Right, Controller.Direction.Horizontal));

        float thrust = controller.GetJoystick(Controller.Side.Left, Controller.Direction.Vertical);
        prop1.Rotate(0, -PropSpeed * thrust, 0, Space.Self);
        prop2.Rotate(0, PropSpeed * thrust, 0, Space.Self);
        prop3.Rotate(0, PropSpeed * thrust, 0, Space.Self);
        prop4.Rotate(0, -PropSpeed * thrust, 0, Space.Self);
    }
}
