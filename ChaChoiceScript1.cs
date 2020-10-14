using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChaChoiceScript1 : MonoBehaviour
{
    int charactors = 0; //현재 선택되어있는 캐릭터 변수 저장
    public GameObject[] titlecha = new GameObject[15];
    public GameObject respawn = null;
    GameObject re;//동산 위에 캐릭터를 생성한후 re변수에 그 캐릭터를 대입할 때 쓰임
    private AudioSource audio;
    public AudioClip jumpSound;

    public GameObject[] lockbutton = new GameObject[15];
    public GameObject[] stagelock = new GameObject[2];
    int chagold;//유저의 돈을 대입할 변수
    string saveStr = "";//캐릭터 보유 유무를 저장하여 마지막에 저장할 때 쓰임
    string saveSta = "";//스테이지 보유 유무를 저장하여 마지막에 저장할 때 쓰임
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
        charactors = PlayerPrefs.GetInt("selectbox", 0);//charactors변수에 현재 선택되어 있는 캐릭터를 불러와 대입
        for (int i = 0; i < 15; i++)
            if (charactors == i)
                re = Instantiate(titlecha[i], respawn.transform.position, Quaternion.Euler(0, 180.0f, 0));//charactors변수에 현재 선택된 캐릭터의 숫자가 들어있고 그 캐릭터를 생성시킴
        re.transform.localScale = new Vector3(2f, 2f, 2f);//캐릭터의 크기를 2f로 변형
        string[] staArr = PlayerPrefs.GetString("stagelock", "0,0").Split(',');//배열에 스테이지와 캐릭터의 보유 유무를 대입 0이면 보유하지 않은 상태 1이면 보유한 상태
        string[] chaArr = PlayerPrefs.GetString("characlock", "0,0,0,0,0,0,0,0,0,0,0").Split(',');
        Starr = new int[staArr.Length];
        for (int i = 0; i < staArr.Length; i++){
            Int32.TryParse(staArr[i], out Starr[i]);//문자열로 저장된 스테이지 보유 유무를 숫자배열로 바꿔줌
            if (Starr[i] == 1)
            {
                stagelock[i].SetActive(false);
            }
        }//배열을 탐색해 1(보유 상태)이면 자물쇠(이미지, 버튼 등)를 없앤다. 캐릭터도 똑같은 ~~(뭐라할지 생각안남)이다.
        Chaintarr = new int[chaArr.Length];
        for (int i = 0; i < chaArr.Length; i++){
            Int32.TryParse(chaArr[i], out Chaintarr[i]);
            if (Chaintarr[i] == 1)
           {
                lockbutton[i].SetActive(false);
           }
        }
        chagold = PlayerPrefs.GetInt("gold");//chagold에 현재 유저의 돈을 대입
        sb = PlayerPrefs.GetInt("selectbox", 0);//sb에 현재 선택되어 있는 캐릭터 번호를 대입
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
    //C0부터 C15까지는 캐릭터버튼을 클릭시 실행되는 함수들 sb(현재 선택되어 있는 캐릭터 번호)를 클릭한 캐릭터의 번호로 바꿈
    public void C0(){
        sb = 0;
    }
    public void C1(){
        sb = 1;
    }
    public void C2()
    {
        sb = 2;
    }
    public void C3(){
        sb = 3;
    }
    public void C4()
    {
        sb = 4;

    }
    public void C5(){
        sb = 5;
    }
    public void C6(){
        sb = 6;
    }
    public void C7(){
        sb = 7;
    }
    public void C8(){
        sb = 8;
    }
    public void C9(){
        sb = 9;
    }
    public void C10(){
        sb = 10;
    }
    public void C11(){
        sb = 11;
    }
    public void C12(){
        sb = 12;
    }
    public void C13(){
        sb = 13;
    }
    public void C14(){
        sb = 14;
    }
    public void C15(){
        sb = 15;
    }
    //L1~L*까지는 잠겨있는 캐릭터들을 돈으로 여는 함수들 잠겨있는 캐릭터 버튼을 클릭시 번호에 맞게 각 함수들 실행
    public void L1()
    {
        int i = 10;//i는 캐릭터의 값
        if (chagold >= i)//현재 가지고 있는 돈이 캐릭터 가격보다 비싸면
        {
            chagold -= i;
            Chaintarr[0] = 1;  //캐릭터 보유 유무 배열을 1(보유)로 바꿈
            lockbutton[0].SetActive(false);
            PlayerPrefs.SetInt("gold", chagold);
            chagold = PlayerPrefs.GetInt("gold");//캐릭터 값을 뺀 돈을 저장후 다시 불러옴
        }
    }
    public void L2()
    {
        int i = 50;
        if (chagold >= i)
        {
            chagold -= i;
            Chaintarr[1] = 1;
            lockbutton[1].SetActive(false);
            PlayerPrefs.SetInt("gold", chagold);
            chagold = PlayerPrefs.GetInt("gold");
        }
    }
    public void L3()
    {
        int i = 250;
        if (chagold >= i)
        {
            chagold -= i;
            Chaintarr[2] = 1;
            lockbutton[2].SetActive(false);
            PlayerPrefs.SetInt("gold", chagold);
            chagold = PlayerPrefs.GetInt("gold");
        }
    }
    //LS1~LS2도 캐릭터 잠금 푸는 함수와 같은 OO(ex)이론, 방법, 형식 스테이지를 구매하고 뒤로가기 버튼을 클릭하지 않고 바로 스테이지로 들어갈 수도 있으니 저장 코드를 추가
    public void LS1()
    {
        int i = 5;
        if (chagold >= i)
        {
            chagold -= i;
            Starr[0] = 1;
            for (int j = 0; j < Starr.Length; j++)
            {
                saveSta = saveSta + Starr[j];
                if (j < Starr.Length && j != Starr.Length - 1)
                    saveSta = saveSta + ",";
            }//구매시 보유 유무 배열을 1로 바꾸고 saveSta문자열에 저장
            PlayerPrefs.SetString("stagelock", saveSta);
            staArr = PlayerPrefs.GetString("stagelock", "0,0").Split(',');
            stagelock[0].SetActive(false);
            PlayerPrefs.SetInt("gold", chagold);
            chagold = PlayerPrefs.GetInt("gold");//바뀐 각종 변수들을 다시 저장
            PlayerPrefs.Save();
        }
    }
    public void LS2()
    {
        int i = 5;
        if (chagold >= i)
        {
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
    public void GoTitle()//캐릭터 선택창에서 뒤로가기 버튼을 눌렀을시 실행되는 함수
    {
        //this.audio.Play();
        for (int i = 0; i < Chaintarr.Length; i++)
        {
            saveStr = saveStr + Chaintarr[i];
            if (i < Chaintarr.Length && i != Chaintarr.Length - 1)
                saveStr = saveStr + ",";
        }
        PlayerPrefs.SetString("characlock", saveStr);//saveStr에 캐릭터 보유 유무 배열을 저장 ex)처음 배열00000에서 첫번째 캐릭터를 구매했을시 10000으로 저장이됨
        PlayerPrefs.SetInt("selectbox", sb);
        ChangeCha();//캐릭터를 선택시 동산위에 서있는 캐릭터를 바꿔야 하기 때문에
        PlayerPrefs.Save();
        CharacterSelect.gameObject.SetActive(false);
    }
    public void StageToTitle()//스테이지 선택창에서 뒤로가기 버튼을 눌렀을시 실행
    {
        //this.audio.Play();
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
    public void SelectButtonClicked()//캐릭터 선택 버튼 클릭시
    {
        //this.audio.Play();
        CharacterSelect.gameObject.SetActive(true);
    }
    public void ChangeCha(){
        Destroy(re);//기존 동산위 캐릭터 삭제
        charactors = PlayerPrefs.GetInt("selectbox", 0);
        for (int i = 0; i < 15; i++)
            if (charactors == i)
                re = Instantiate(titlecha[i], respawn.transform.position, Quaternion.Euler(0, 180.0f, 0));
        re.transform.localScale = new Vector3(2f, 2f, 2f);//위에 Awake함수 캐릭터 생성 코드와 같이 새롭게 선택된 캐릭터를 생성
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