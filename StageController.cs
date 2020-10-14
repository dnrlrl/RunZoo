using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageController : MonoBehaviour {
    public Text goldM;
    public static int fishgold = 0;
    public void goldMessage() {
        goldM.text = "+ " + fishgold + "";
        fishgold = 0;
    }
}
