using UnityEngine;
using System.Collections;

public class placerCone : MonoBehaviour {

    public GameObject cone1;
    public GameObject cone2;
    public GameObject cone3;
    public GameObject cone4;
    public GameObject dust;
    public GameObject controller;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        cone1.transform.position = new Vector3(-4, 0, -4);
        cone2.transform.position = new Vector3(-4, 0, 4);
        cone3.transform.position = new Vector3(4, 0, -4);
        cone4.transform.position = new Vector3(4, 0, 4);

        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
        Destroy(dust);
        controller.GetComponent<main2Controller>().clic++;
    }

}
