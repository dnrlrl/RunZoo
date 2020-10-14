using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour {
	public NejikoController nejiko;
	public Text scoreLabel;
	//public LifePanel lifePanel;
    public GameObject Next_level;
	public NextLevel Fish;
	public void Update () {
		//스코어 레이블을 업데이트
		//int score=CalcScore();
		//scoreLabel.text = "Fish: " + score + "m";
	
		//라이프 패널을 업데이트
		//이 이후의 업데이트는 멈춤
		//enabled=false;
			//하이 스코어를 업데이트(과거 최고 점수보다 높은 경우 갱신하여 저장)
			//if (PlayerPrefs.GetInt ("HighScore") < score) {
			//PlayerPrefs.SetInt ("HighScore", score);
			//}
           // Next_level.SetActive(true);
           // nejiko.speedZ = 0;
          //  Invoke("ReturnToTitle",1.0f);
     //   }
	//}
		//}
	//}

	//int CalcScore()
	//{
		//네지코의 주행 거리를 스코어로 한다.
		//return (int) nejiko.transform.position.z;
	//}
	}
	//int CalcScore()
	//{
		//return (int)PlayerPrefs.GetInt("gold");
	//}
}
