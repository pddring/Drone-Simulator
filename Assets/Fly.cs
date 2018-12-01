using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour {
    Rigidbody rb;
    public Vector3 direction;
    public float min, max;

    float offset, scale;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        offset = (max - min) / 2;
        scale = (max - min) / 2;
	}
	
	void FixedUpdate () {
        float h = (Input.GetAxis("Horizontal") + offset) / scale;
        Debug.Log(Input.GetAxis("Horizontal") + " scaled: " + h);
        rb.AddForce(direction * h);
	}
}
