using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMoveCam : MonoBehaviour {

    Vector2?[] touchPrevPos = { null, null };
    Vector2 touchPrevVector;
    float touchPrevDist;

    // Use this for initialization
    void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 0)
        {
            touchPrevPos[0] = null;
            touchPrevPos[1] = null;
        }
        else if (Input.touchCount == 1)
        {
            if (touchPrevPos[0] == null || touchPrevPos[1] != null)
            {
                touchPrevPos[0] = Input.GetTouch(0).position;
                touchPrevPos[1] = null;
            }
            else
            {
                Vector2 touchNewPos = Input.GetTouch(0).position;
                transform.position += transform.TransformDirection((Vector3)((touchPrevPos[0] - touchNewPos) * Camera.main.orthographicSize / Camera.main.pixelHeight * 2f));
                Vector3 temp;
                temp.x = Mathf.Clamp(transform.position.x, 1.8f, 1.8f);
                temp.y = Mathf.Clamp(transform.position.y, 0, 0.6f);
                temp.z = Mathf.Clamp(transform.position.z, -1, 1);
                transform.position = temp;
                touchPrevPos[0] = touchNewPos;
            }
        }
        else
        {
            return;
        }

    }
}