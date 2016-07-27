using UnityEngine;
using System.Collections;

public class boutonAspi : MonoBehaviour {

    public GameObject Aspirateur;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        Aspirateur.GetComponent<Animator>().enabled = true;
    }
}
