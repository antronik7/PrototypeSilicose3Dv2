using UnityEngine;
using System.Collections;

public class main3ClickTransision : MonoBehaviour {

    public GameObject transicion;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        StartCoroutine(waitPlz());
    }

    IEnumerator waitPlz()
    {
        yield return new WaitForSeconds(2);
        transicion.GetComponent<Animator>().enabled = true;
    }
}
