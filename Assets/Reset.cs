using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour {
    public KeyCode resetKey;
    public Vector3 resetPosition;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(resetKey))
        {
            transform.SetPositionAndRotation(resetPosition, Quaternion.identity);
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.velocity = Vector3.zero;
        }
	}
}
