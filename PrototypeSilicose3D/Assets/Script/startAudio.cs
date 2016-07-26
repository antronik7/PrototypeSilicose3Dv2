using UnityEngine;
using System.Collections;

public class startAudio : MonoBehaviour {

	// Use this for initialization
	void Start () {

        gameObject.GetComponent<AudioSource>().Play();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
