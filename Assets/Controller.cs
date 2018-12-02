using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
    public enum Side
    {
        Left, Right
    }

    public enum Direction
    {
        Horizontal, Vertical
    }

    float lv, lh, rv, rh;

    public void SetJoystick(Side side, Direction direction, float value)
    {
        switch (side)
        {
            case Side.Left:
                switch (direction)
                {
                    case Direction.Horizontal:
                        lh = value;
                        break;
                    case Direction.Vertical:
                        lv = value;
                        break;
                }
                break;
            case Side.Right:
                switch (direction)
                {
                    case Direction.Horizontal:
                        rh = value;
                        break;
                    case Direction.Vertical:
                        rv = value;
                        break;
                }
                break;
        }
    }

    public float GetJoystick(Side side, Direction direction)
    {
        switch(side)
        {
            case Side.Left:
                switch(direction)
                {
                    case Direction.Horizontal:
                        return lh;
                    case Direction.Vertical:
                        return lv;
                }
                break;
            case Side.Right:
                switch (direction)
                {
                    case Direction.Horizontal:
                        return rh;
                    case Direction.Vertical:
                        return rv;
                }
                break;
        }
        return 0;
    }

	// Use this for initialization
	void Start () {
        lv = lh = rv = rh = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
