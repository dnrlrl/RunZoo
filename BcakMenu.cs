using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BcakMenu : MonoBehaviour {
    Transform backmenu;
    void Start () {
        backmenu = GameObject.Find("Canvas").transform.Find("backmenu");
    }
	
	void Update () {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                backmenu.gameObject.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
    public void backHome() {
        SummonOnStart.lastgold = 0;
        stageEnd.lastgold = 0;
        StageController.fishgold = 0;
        Time.timeScale = 1;
        SceneManager.LoadScene("Title", LoadSceneMode.Single);
    }
    public void gameEnd()
    {
        Application.Quit();
    }
    public void cancel(){
        Time.timeScale = 1;
        backmenu.gameObject.SetActive(false);
    }
}
