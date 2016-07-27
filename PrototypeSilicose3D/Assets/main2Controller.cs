using UnityEngine;
using System.Collections;

public class main2Controller : MonoBehaviour {

    public int score = 0;
    public int clic = 0;

    public GameObject le1;
    public GameObject le2;
    public GameObject le3;
    public GameObject le4;
    public GameObject le5;
    public GameObject le6;
    public GameObject le7;
    public GameObject le8;
    public GameObject le9;
    public GameObject le10;
    public GameObject le11;
    public GameObject le12;

    public GameObject target1;
    public GameObject target2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
        if(clic == 1)
        {
            le1.transform.position = Vector3.MoveTowards(le1.transform.position, target1.transform.position, Time.deltaTime * 25);
            le2.transform.position = Vector3.MoveTowards(le2.transform.position, target2.transform.position, Time.deltaTime * 25);
        }
        if (clic == 2)
        {
            le2.transform.position = Vector3.MoveTowards(le2.transform.position, target1.transform.position, Time.deltaTime * 25);
            le3.transform.position = Vector3.MoveTowards(le3.transform.position, target2.transform.position, Time.deltaTime * 25);
        }

        if (clic == 3)
        {
            le3.transform.position = Vector3.MoveTowards(le3.transform.position, target1.transform.position, Time.deltaTime * 25);
            le4.transform.position = Vector3.MoveTowards(le4.transform.position, target2.transform.position, Time.deltaTime * 25);
        }

        if (clic == 4)
        {
            le4.transform.position = Vector3.MoveTowards(le4.transform.position, target1.transform.position, Time.deltaTime * 25);
            le5.transform.position = Vector3.MoveTowards(le5.transform.position, target2.transform.position, Time.deltaTime * 25);
        }

        if (clic == 5)
        {
            le5.transform.position = Vector3.MoveTowards(le5.transform.position, target1.transform.position, Time.deltaTime * 25);
            le6.transform.position = Vector3.MoveTowards(le6.transform.position, target2.transform.position, Time.deltaTime * 25);
        }

    }
}
