﻿using UnityEngine;
using System.Collections;

public class arrowfacecamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(Camera.main.transform.position, Vector3.left);
    }
}
