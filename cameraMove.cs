using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour {
    float speed = 0.4f;
    void Start () {
        var directionL = transform.forward * Time.deltaTime * speed;
        transform.Translate(directionL, Space.World);
    }

    void Update () {
        moveObject();
	}
    void moveObject() {
        this.transform.Translate(new Vector3(0.0f, 0.0f, speed * Time.deltaTime));
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(16.0f,0.95f,45.0f), speed * Time.deltaTime);
    }
}
