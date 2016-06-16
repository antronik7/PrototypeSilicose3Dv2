using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimerController : MonoBehaviour {

    Text leText;
	// Use this for initialization
	void Start () {
        leText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        leText.text = GameManager.instance.timeString;
	}
}
