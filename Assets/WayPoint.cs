using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WayPoint : MonoBehaviour {
    private float altitude;
    private float distance;
    private int score = 0;
    public Text scoreLabel;

    public float minDistance = 5;
    public float minAltitude = 1;

    public Vector3[] positions;
    private int positionIndex = -1;
    
    public void updateDistance(float altitude, float distance)
    {
        this.altitude = altitude;
        this.distance = distance;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (altitude < minAltitude  && distance < minDistance)
        {
            positionIndex = (positionIndex + 1) % positions.Length;
            transform.SetPositionAndRotation(positions[positionIndex], Quaternion.identity);
            score++;
            if (scoreLabel)
                scoreLabel.text = score.ToString();
        } 
	}

    
}
