using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleWithKey : MonoBehaviour {

    public KeyCode key;
    bool on = false;
    public Vector3 axis;
    public float angle;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        if(Input.GetKeyDown(key))
        {
            if(on)
            {
                transform.Rotate(axis, angle);
            } else
            {
                transform.Rotate(axis, -angle);
            }
            on = !on;
        }
    }
}
