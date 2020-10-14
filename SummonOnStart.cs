using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SummonOnStart : MonoBehaviour
{
    public static int lastgold = 0;
    int thisgold;
    //카메라 이동
    Vector3 diff;
    public GameObject target;
    public float followSpeed;

    int charactors=0;
    public GameObject[] sHero = new GameObject[15];
    public GameObject respawn = null;
    GameObject re;
    private void Awake(){
        charactors = PlayerPrefs.GetInt("selectbox", 0);
        for (int i = 0; i < 15; i++)
            if (charactors == i)
                re=Instantiate(sHero[i], respawn.transform.position, Quaternion.identity);
	}
    void Start()
    {
        thisgold = PlayerPrefs.GetInt("gold", 0);
        target = re;
        //카메라
        diff = target.transform.position - transform.position;
    }
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(
            transform.position,
            target.transform.position - diff,
            Time.deltaTime * followSpeed
        );
    }
    public void CMoveToLeft(){
        re.GetComponent<NejikoController>().MoveToLeft();
    }
    public void CMoveToRight()
    {
        re.GetComponent<NejikoController>().MoveToRight();
    }
    public void CJump()
    {
        re.GetComponent<NejikoController>().Jump();
    }
    public void GotoTitle() {
        thisgold += lastgold;
        PlayerPrefs.SetInt("gold", thisgold);
        PlayerPrefs.Save();
        lastgold = 0;
        Time.timeScale = 1;
        SceneManager.LoadScene("Title", LoadSceneMode.Single);
    }
}
