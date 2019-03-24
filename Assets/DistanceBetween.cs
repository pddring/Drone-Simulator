using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceBetween : MonoBehaviour {
    public Transform movingObject;
    public Transform targetObject;
    public Text altitudeLabel;
    public WayPoint waypoint;


    private Text label;
	// Use this for initialization
	void Start () {
        label = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 difference = movingObject.position - targetObject.position;
        float altitude = difference.y;
        difference.y = 0;
        float distance =  Mathf.Sqrt (difference.sqrMagnitude);

        if(altitudeLabel )
        {
            altitudeLabel.text = altitude.ToString("F1");
        }

        if(waypoint)
        {
            waypoint.updateDistance(altitude, distance);
        }
        label.text =distance.ToString("F1");
	}
}
