using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {
    public GameObject Next_level;
    //public int max_level;
    public string num_level;
    public static int thelevel;
    public int t;
    public NejikoController cha;
    void Start()
    {
        thelevel = t;
    }
	//void Update()
	//{
	//	scoreLabel.text = "Fish: " + gold + "Mari";
	//}
    public static void the_level(int t)
    {
        thelevel = t;
        PlayerPrefs.SetInt("thelevel", thelevel);
    }
    public void next()
    {

        LevelUnlocked.Next_Level();
        SceneManager.LoadScene("Title");
    }
    public void _level()
    {
        the_level(t);
    }
	/*
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag=="FreshFish")
		{
			Destroy(other.gameObject);
			thisgold++;
			PlayerPrefs.SetInt("gold", gold+thisgold);
		}
	}
    */
}
