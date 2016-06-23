using UnityEngine;
using System.Collections;

public class TransicionEnter : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void TransicionEnd()
    {
        GameManager.instance.StartGame();
        Destroy(gameObject);
    }
}
