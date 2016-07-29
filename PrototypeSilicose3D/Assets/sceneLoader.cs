using UnityEngine;
using System.Collections;

public class sceneLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("1"))
            Application.LoadLevel("Menu");

        if (Input.GetKeyDown("2"))
            Application.LoadLevel("Tuto");

        if (Input.GetKeyDown("3"))
            Application.LoadLevel("main");

        if(Input.GetKeyDown("4"))
            Application.LoadLevel("main2");

        if (Input.GetKeyDown("5"))
            Application.LoadLevel("main3");

        if (Input.GetKeyDown("6"))
            Application.LoadLevel("card");

        if (Input.GetKeyDown("7"))
            Application.LoadLevel("animation");
    }
}
