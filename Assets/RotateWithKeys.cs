using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWithKeys : MonoBehaviour {
    /// <summary>
    /// Key to press to increase rotation
    /// </summary>
    public KeyCode increaseKey;

    /// <summary>
    /// Key to press to decrease rotation
    /// </summary>
    public KeyCode decreaseKey;

    public KeyCode resetKey;

    public float maxRotation;
    public float minRotation;

    public bool springy;

    /// <summary>
    /// Angle to apply when the key is pressed
    /// </summary>
    public float angle;

    private float currentRotation = 0;

    /// <summary>
    /// Axis to rotate around
    /// </summary>
    public Vector3 axis;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Reset()
    {
        transform.Rotate(axis, -currentRotation);
        currentRotation = 0;
    }

    private void FixedUpdate()
    {
        if(springy && (Input.GetKeyUp(increaseKey) || Input.GetKeyUp(decreaseKey)))
        {
            Reset();
        }

        if(Input.GetKey(increaseKey))
        {
            if(angle + currentRotation < maxRotation  )
            {
                transform.Rotate(axis, angle);
                currentRotation += angle;
            }
            
        }

        if (Input.GetKey(decreaseKey))
        {
            if(currentRotation - angle > minRotation)
            {
                transform.Rotate(axis, -angle);
                currentRotation -= angle;
            } 
        }

        if(Input.GetKeyDown(resetKey))
        {
            Reset();
        }


    }
}
