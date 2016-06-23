using UnityEngine;
using System.Collections;

public class main2Controller : MonoBehaviour {

    public int score = 0;
    public GameObject le1;
    public GameObject le2;

    public GameObject target1;
    public GameObject target2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
        if(score > 2)
        {
            le1.transform.position = Vector3.MoveTowards(le1.transform.position, target1.transform.position, Time.deltaTime * 50);
            le2.transform.position = Vector3.MoveTowards(le2.transform.position, target2.transform.position, Time.deltaTime * 50);
        }

	}
}
