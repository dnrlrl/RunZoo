using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUnlocked : MonoBehaviour {
    public static int level = 1;
    public int max_level;
    public GameObject[] levelUnlocked;
    void Start()
    {
        level = PlayerPrefs.GetInt("level", level);
    }
    void Update()
    {
        for (int i = 1; i < max_level; i++)
        {
            if (i <= level)
            {
                levelUnlocked[i].SetActive(false);
            }
            else
            {
                levelUnlocked[i].SetActive(true);
            }
        }
    }
    public static void Next_Level()
    {
        Debug.Log(level + ",NextLevel.thelevel= " + NextLevel.thelevel);
        if (level == NextLevel.thelevel)
        {
            level += 1;
            Debug.Log("level= " + level);
            PlayerPrefs.SetInt("level", level);
        }
    }
    /*
    public void add_level()
    {
        Next_Level();
        //Application.LoadLevel("Main");
    */
}