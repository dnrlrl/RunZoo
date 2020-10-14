using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TItleController : MonoBehaviour {
	public Text highScoreLabel;
    private AudioSource audio;
    public AudioClip jumpSound;
    public GameObject StageCho;
    public GameObject Option;
    void Start () {
        this.audio = this.gameObject.AddComponent<AudioSource>();
        this.audio.clip = this.jumpSound;
        this.audio.loop = false;
    }
	public void OnStartButtonClicked(){
        this.audio.Play();
        StageCho.gameObject.SetActive(true);
	}
	public void OptionButtonClicked(){
        this.audio.Play();
        Option.gameObject.SetActive(true);
	}
    public void OptionButtoncancel()
    {
        this.audio.Play();
        Option.gameObject.SetActive(false);
    }
    void Update(){
        highScoreLabel.text = PlayerPrefs.GetInt("gold", 0) + "";
    }
    public void GoStage1() {
        SceneManager.LoadScene("stage1");
    }
    public void GoStage2(){
        SceneManager.LoadScene("stage2");
    }
    public void GoStage3(){
        SceneManager.LoadScene("stage3");
    }
}
