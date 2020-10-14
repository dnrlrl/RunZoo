using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartSceen : MonoBehaviour {
    void Update(){
        if (Input.touchCount >= 1)
            SceneManager.LoadScene("Title");
        if (Input.GetMouseButton(0))
            SceneManager.LoadScene("Title");
    }
}