using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stageEnd : MonoBehaviour
{
    string saveStr = "";
    string[] chaArr;
    int[] Chaintarr;
    public static int lastgold = 0;
    int thisgold;
    void Start()
    {
        thisgold = PlayerPrefs.GetInt("gold", 0);
    }
    public void stage1() {
        string[] chaArr = PlayerPrefs.GetString("characlock", "0,0,0,0,0,0,0,0,0,0,0").Split(',');
        Chaintarr = new int[chaArr.Length];
        for (int i = 0; i < chaArr.Length; i++)
        {
            Int32.TryParse(chaArr[i], out Chaintarr[i]);
        }
        thisgold += lastgold;
        PlayerPrefs.SetInt("gold", thisgold);
        lastgold = 0;
        Chaintarr[2] = 1;
        for (int i = 0; i < Chaintarr.Length; i++)
        {
            saveStr = saveStr + Chaintarr[i];
            if (i < Chaintarr.Length && i != Chaintarr.Length - 1)
                saveStr = saveStr + ",";
        }
        PlayerPrefs.SetString("characlock", saveStr);
        PlayerPrefs.Save();
        Time.timeScale = 1;
        SceneManager.LoadScene("Title", LoadSceneMode.Single);
    }
    public void stage1H()
    {
        string[] chaArr = PlayerPrefs.GetString("characlock", "0,0,0,0,0,0,0,0,0,0,0,0,0,0").Split(',');
        Chaintarr = new int[chaArr.Length];
        for (int i = 0; i < chaArr.Length; i++)
        {
            Int32.TryParse(chaArr[i], out Chaintarr[i]);
        }
        thisgold += lastgold;
        PlayerPrefs.SetInt("gold", thisgold);
        Chaintarr[10] = 1;
        for (int i = 0; i < Chaintarr.Length; i++)
        {
            saveStr = saveStr + Chaintarr[i];
            if (i < Chaintarr.Length && i != Chaintarr.Length - 1)
                saveStr = saveStr + ",";
        }
        PlayerPrefs.SetString("characlock", saveStr);
        PlayerPrefs.Save();
        lastgold = 0;
        Time.timeScale = 1;
        SceneManager.LoadScene("Title", LoadSceneMode.Single);
    }
    public void stage2()
    {
        string[] chaArr = PlayerPrefs.GetString("characlock", "0,0,0,0,0,0,0,0,0,0,0,0,0,0").Split(',');
        Chaintarr = new int[chaArr.Length];
        for (int i = 0; i < chaArr.Length; i++)
        {
            Int32.TryParse(chaArr[i], out Chaintarr[i]);
        }
        thisgold += lastgold;
        PlayerPrefs.SetInt("gold", thisgold);
        Chaintarr[5] = 1;
        for (int i = 0; i < Chaintarr.Length; i++)
        {
            saveStr = saveStr + Chaintarr[i];
            if (i < Chaintarr.Length && i != Chaintarr.Length - 1)
                saveStr = saveStr + ",";
        }
        PlayerPrefs.SetString("characlock", saveStr);
        PlayerPrefs.Save();
        lastgold = 0;
        Time.timeScale = 1;
        SceneManager.LoadScene("Title", LoadSceneMode.Single);
    }
    public void stage3()
    {
        string[] chaArr = PlayerPrefs.GetString("characlock", "0,0,0,0,0,0,0,0,0,0,0,0,0,0").Split(',');
        Chaintarr = new int[chaArr.Length];
        for (int i = 0; i < chaArr.Length; i++)
        {
            Int32.TryParse(chaArr[i], out Chaintarr[i]);
        }
        thisgold += lastgold;
        PlayerPrefs.SetInt("gold", thisgold);
        Chaintarr[9] = 1;
        for (int i = 0; i < Chaintarr.Length; i++)
        {
            saveStr = saveStr + Chaintarr[i];
            if (i < Chaintarr.Length && i != Chaintarr.Length - 1)
                saveStr = saveStr + ",";
        }
        PlayerPrefs.SetString("characlock", saveStr);
        PlayerPrefs.Save();
        lastgold = 0;
        Time.timeScale = 1;
        SceneManager.LoadScene("Title", LoadSceneMode.Single);
    }
}

