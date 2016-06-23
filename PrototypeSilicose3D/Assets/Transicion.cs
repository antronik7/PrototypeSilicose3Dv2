using UnityEngine;
using System.Collections;

public class Transicion : MonoBehaviour {

    public string NomScene;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void changerScene()
    {
        Application.LoadLevel(NomScene);
    }
}
