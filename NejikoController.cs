using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NejikoController : MonoBehaviour {
    private AudioSource audio;
    public AudioClip attackSound;
    public static int thisgold = 0;

    const int MinLane = -3;
	const int MaxLane = 3;
	const float LaneWidth = 1.0f;
	CharacterController  controller;
	Animator animator;
    Transform gameover;
    Vector3 moveDirection=Vector3.zero;
	int targetLane;

	public float gravity;
	public float speedZ;
	public float speedX;
	public float speedJump;
    float speedtime;
    float timeSpan;
    float checkTime = 30.0f;
    float checkTime2 = 70.0f;
    int jumpcheck;
    void Awake() {

    }
	void Start () {
        jumpcheck = 0;
        this.audio = this.gameObject.AddComponent<AudioSource>();
        this.audio.clip = this.attackSound;
        this.audio.loop = false;

        thisgold = PlayerPrefs.GetInt("gold", 0);
        gameover = GameObject.Find("Canvas").transform.Find("gameover");
        controller = GetComponent<CharacterController>();
		animator = GetComponent<Animator> ();
        timeSpan = 0.0f;
        //checkTime = 5.0f;
    }
	void Update () {
        speedtime+= Time.deltaTime;
        timeSpan += Time.deltaTime;
        if (timeSpan > checkTime) {
            speedZ = 12;
        }
        if (timeSpan > checkTime2)
            speedZ = 17;
        if (controller.isGrounded)
            jumpcheck = 0;
        moveDirection.z = speedZ;
        //X방향은 목표의 포지션까지의 차등 비율로 속도를 계산
        float ratioX = (targetLane * LaneWidth - transform.position.x) / LaneWidth;//수직 이동의 속도 계산
		moveDirection.x = ratioX * speedX;
		//중력만큼의 힘을 매 프레임에 추가
		moveDirection.y -= gravity * Time.deltaTime;
		//캐릭터 이동 실행
		Vector3 globalDirection = transform.TransformDirection (moveDirection);
		controller.Move (globalDirection * Time.deltaTime);
		//이동 후 접지하고 있으면 Y 방향의 속도는 리셋한다.(중력)
		if (controller.isGrounded)
			moveDirection.y = 0;
    }

	public void MoveToLeft()
	{
        if (targetLane > MinLane){
            targetLane--;
            animator.SetTrigger("Move_Left");
        }
	}
	public void MoveToRight(){
        if (controller.isGrounded && targetLane < MaxLane)
        {
            targetLane++;
            animator.SetTrigger("Move_Right");
        }
    }
	public void Jump(){
        if (jumpcheck == 0)
        {
            jumpcheck = 1;
            moveDirection.y = speedJump;
            animator.SetTrigger("Jump");
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "FreshFish")
        {
            SummonOnStart.lastgold++;
            stageEnd.lastgold++;
            StageController.fishgold++;
            Destroy(other.gameObject);
        }
        else if(other.gameObject.tag == "RunFish")
        {
            speedtime = 0.0f;
            float speed = speedZ;
            speedZ = 30;
            if (speedtime > 5.0f)
                speedZ = speed;
        }
    }
    void gameoverI()
    {
        Time.timeScale = 0;
        gameover.gameObject.SetActive(true);//
    }
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "enemy")
        {
            this.audio.Play();
            moveDirection.z = 0;
            speedZ = 0;
            timeSpan = 0.0f;
            animator.SetTrigger("Die2");
            GameObject.Find("Canvas").GetComponent<StageController>().goldMessage();
            Invoke("gameoverI", 0.3f);
        }
        else if (hit.gameObject.tag == "Finish")
        {
            moveDirection.z = 0;
            speedZ = 0;
            timeSpan = 0.0f;
            Time.timeScale = 0;
            gameover = GameObject.Find("Canvas").transform.Find("clear");
            gameover.gameObject.SetActive(true);
        }
        else if (hit.gameObject.tag == "Hidden")
        {
            moveDirection.z = 0;
            speedZ = 0;
            timeSpan = 0.0f;
            Time.timeScale = 0;
            gameover = GameObject.Find("Canvas").transform.Find("Hidden");
            gameover.gameObject.SetActive(true);
        }
    }
}
