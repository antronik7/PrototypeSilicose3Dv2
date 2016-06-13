using UnityEngine;
using System.Collections;

public class CubeHover : MonoBehaviour {

    Ray ray;
    RaycastHit hit;
    string lastHit = "";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out hit))
        {
            if(lastHit != hit.collider.name)
            { 
                print(hit.collider.name);
                lastHit = hit.collider.name;
            }
        }
        else
        {
            lastHit = "";
        }

	}

}
