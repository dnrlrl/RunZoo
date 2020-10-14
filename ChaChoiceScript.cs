using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChaChoiceScript : MonoBehaviour
{
    int charactors = 0;
    public GameObject[] titlecha = new GameObject[15];
    public GameObject respawn = null;
    GameObject re;
    private AudioSource audio;
    public AudioClip jumpSound;

    public GameObject[] lockbutton = new GameObject[15];
    public GameObject[] stagelock = new GameObject[2];
    int chagold;
    string saveStr = "";
    string saveSta = "";
    string[] chaArr;
    string[] staArr;
    int[] Chaintarr;
    int[] Starr;

    private Quaternion turn = Quaternion.identity;
    public static int charactorNum = 0;
    int sb;
    int value = 0;
    public Transform CharacterSelect;
    public Transform StageSelect;
    void Awake(){
        charactors = PlayerPrefs.GetInt("selectbox", 0);
        for (int i = 0; i < 15; i++)
            if (charactors == i)
                re = Instantiate(titlecha[i], respawn.transform.position, Quaternion.Euler(0, 180.0f, 0));
        re.transform.localScale = new Vector3(2f, 2f, 2f);
        string[] staArr = PlayerPrefs.GetString("stagelock", "0,0").Split(',');
        string[] chaArr = PlayerPrefs.GetString("characlock", "0,0,0,0,0,0,0,0,0,0,0").Split(',');
        Starr = new int[staArr.Length];
        for (int i = 0; i < staArr.Length; i++){
            Int32.TryParse(staArr[i], out Starr[i]);
            if (Starr[i] == 1)
            {
                stagelock[i].SetActive(false);
            }
        }
        Chaintarr = new int[chaArr.Length];
        for (int i = 0; i < chaArr.Length; i++){
            Int32.TryParse(chaArr[i], out Chaintarr[i]);
            if (Chaintarr[i] == 1)
           {
                lockbutton[i].SetActive(false);
           }
        }
        chagold = PlayerPrefs.GetInt("gold");
        sb = PlayerPrefs.GetInt("selectbox", 0);
        charactorNum = sb;
    }
    void Start(){
        this.audio = this.gameObject.AddComponent<AudioSource>();
        this.audio.clip = this.jumpSound;
        this.audio.loop = false;
        turn.eulerAngles = new Vector3(0, value, 0);
    }
    void Update(){
        turn.eulerAngles = new Vector3(0, value, 0);
        transform.rotation = Quaternion.Slerp(transform.rotation, turn, Time.deltaTime * 5.0f);
    }
    public void C0(){
        this.audio.Play();
        sb = 0;
    }
    public void C1(){
        this.audio.Play();
        sb = 1;
    }
    public void C2(){
        this.audio.Play();
        sb = 2;
    }
    public void C3(){
        this.audio.Play();
        sb = 3;
    }
    public void C4() {
        this.audio.Play();
        sb = 4;
    }
    public void C5(){
        this.audio.Play();
        sb = 5;
    }
    public void C6(){
        this.audio.Play();
        sb = 6;
    }
    public void C7(){
        this.audio.Play();
        sb = 7;
    }
    public void C8(){
        this.audio.Play();
        sb = 8;
    }
    public void C9(){
        this.audio.Play();
        sb = 9;
    }
    public void C10(){
        this.audio.Play();
        sb = 10;
    }
    public void C11(){
        this.audio.Play();
        sb = 11;
    }
    public void C12(){
        this.audio.Play();
        sb = 12;
    }
    public void C13(){
        this.audio.Play();
        sb = 13;
    }
    public void C14(){
        this.audio.Play();
        sb = 14;
    }
    public void C15(){
        sb = 15;
    }
    public void L1()
    {
        int i = 30;
        if (chagold >= i)
        {
            this.audio.Play();
            chagold -= i;
            Chaintarr[0] = 1;
            lockbutton[0].SetActive(false);
            PlayerPrefs.SetInt("gold", chagold);
            chagold = PlayerPrefs.GetInt("gold");
        }
    }
    public void L2()
    {
        int i = 50;
        if (chagold >= i)
        {
            this.audio.Play();
            chagold -= i;
            Chaintarr[1] = 1;
            lockbutton[1].SetActive(false);
            PlayerPrefs.SetInt("gold", chagold);
            chagold = PlayerPrefs.GetInt("gold");
        }
    }
    public void L3()
    {
        int i = 100;
        if (chagold >= i)
        {
            this.audio.Play();
            chagold -= i;
            Chaintarr[3] = 1;
            lockbutton[3].SetActive(false);
            PlayerPrefs.SetInt("gold", chagold);
            chagold = PlayerPrefs.GetInt("gold");
        }
    }
    public void L4()
    {
        int i = 130;
        if (chagold >= i)
        {
            this.audio.Play();
            chagold -= i;
            Chaintarr[4] = 1;
            lockbutton[4].SetActive(false);
            PlayerPrefs.SetInt("gold", chagold);
            chagold = PlayerPrefs.GetInt("gold");
        }
    }
    public void L5()
    {
        int i = 180;
        if (chagold >= i)
        {
            this.audio.Play();
            chagold -= i;
            Chaintarr[6] = 1;
            lockbutton[6].SetActive(false);
            PlayerPrefs.SetInt("gold", chagold);
            chagold = PlayerPrefs.GetInt("gold");
        }
    }
    public void L6()
    {
        int i = 220;
        if (chagold >= i)
        {
            this.audio.Play();
            chagold -= i;
            Chaintarr[7] = 1;
            lockbutton[7].SetActive(false);
            PlayerPrefs.SetInt("gold", chagold);
            chagold = PlayerPrefs.GetInt("gold");
        }
    }
    public void L7()
    {
        int i = 250;
        if (chagold >= i)
        {
            this.audio.Play();
            chagold -= i;
            Chaintarr[8] = 1;
            lockbutton[8].SetActive(false);
            PlayerPrefs.SetInt("gold", chagold);
            chagold = PlayerPrefs.GetInt("gold");
        }
    }
    public void LS1()
    {
        int i = 100;
        if (chagold >= i)
        {
            this.audio.Play();
            chagold -= i;
            Starr[0] = 1;
            for (int j = 0; j < Starr.Length; j++)
            {
                saveSta = saveSta + Starr[j];
                if (j < Starr.Length && j != Starr.Length - 1)
                    saveSta = saveSta + ",";
            }
            PlayerPrefs.SetString("stagelock", saveSta);
            staArr = PlayerPrefs.GetString("stagelock", "0,0").Split(',');
            stagelock[0].SetActive(false);
            PlayerPrefs.SetInt("gold", chagold);
            chagold = PlayerPrefs.GetInt("gold");
            PlayerPrefs.Save();
        }
    }
    public void LS2()
    {
        int i = 300;
        if (chagold >= i)
        {
            this.audio.Play();
            chagold -= i;
            Starr[1] = 1;
            for (int j = 0; j < Starr.Length; j++)
            {
                saveSta = saveSta + Starr[j];
                if (j < Starr.Length && j != Starr.Length - 1)
                    saveSta = saveSta + ",";
            }
            PlayerPrefs.SetString("stagelock", saveSta);
            staArr = PlayerPrefs.GetString("stagelock", "0,0").Split(',');
            stagelock[1].SetActive(false);
            PlayerPrefs.SetInt("gold", chagold);
            chagold = PlayerPrefs.GetInt("gold");
            PlayerPrefs.Save();
        }
    }
    public void GoTitle()
    {
        this.audio.Play();
        for (int i = 0; i < Chaintarr.Length; i++)
        {
            saveStr = saveStr + Chaintarr[i];
            if (i < Chaintarr.Length && i != Chaintarr.Length - 1)
                saveStr = saveStr + ",";
        }
        PlayerPrefs.SetString("characlock", saveStr);
        PlayerPrefs.SetInt("selectbox", sb);
        ChangeCha();
        PlayerPrefs.Save();
        CharacterSelect.gameObject.SetActive(false);
    }
    public void StageToTitle()
    {
        this.audio.Play();
        for (int i = 0; i < Starr.Length; i++)
        {
            saveSta = saveSta + Starr[i];
            if (i < Starr.Length && i != Starr.Length - 1)
                saveSta = saveSta + ",";
        }
        PlayerPrefs.SetString("stagelock", saveSta);
        chagold = PlayerPrefs.GetInt("gold");
        string[] staArr = PlayerPrefs.GetString("stagelock", "0,0").Split(',');
        Starr = new int[staArr.Length];
        for (int i = 0; i < staArr.Length; i++)
        {
            Int32.TryParse(staArr[i], out Starr[i]);
            if (Starr[i] == 1)
            {
                stagelock[i].SetActive(false);
            }
        }
        saveSta = "";
        PlayerPrefs.Save();
        StageSelect.gameObject.SetActive(false);
    }
    public void SelectButtonClicked()
    {
        this.audio.Play();
        CharacterSelect.gameObject.SetActive(true);
    }
    public void ChangeCha(){
        Destroy(re);
        charactors = PlayerPrefs.GetInt("selectbox", 0);
        for (int i = 0; i < 15; i++)
            if (charactors == i)
                re = Instantiate(titlecha[i], respawn.transform.position, Quaternion.Euler(0, 180.0f, 0));
        re.transform.localScale = new Vector3(2f, 2f, 2f);
        chaArr = PlayerPrefs.GetString("characlock", "0,0,0,0,0,0,0,0,0,0,0").Split(',');
        Chaintarr = new int[chaArr.Length];
        for (int i = 0; i < chaArr.Length; i++)
        {
            Int32.TryParse(chaArr[i], out Chaintarr[i]);
        }
        chagold = PlayerPrefs.GetInt("gold");
        saveStr = "";
    }
}