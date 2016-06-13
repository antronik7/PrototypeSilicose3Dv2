using UnityEngine;
using System.Collections;

public class simpleAi : MonoBehaviour {

    private bool first = true;
    public Transform target1;
    public Transform target2;

    // Use this for initialization
    void Start () {
        InvokeRepeating("move", 1, 3);
    }
	
	// Update is called once per frame
	void Update () {

        if(first)
        {
            transform.position = Vector3.MoveTowards(transform.position, target1.position, 0.1f);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, target2.position, 0.1f);
        }
	
	}

    void move()
    {
        int number = Random.Range(0, 2);

        if(number == 0)
        {
            first = false;
        }
        else
        {
            first = true;
        }
    }
}
