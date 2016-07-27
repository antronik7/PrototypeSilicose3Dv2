using UnityEngine;
using System.Collections;

public class MauvaiseReponse : MonoBehaviour {

    public GameObject objectBonneReponse;
    public GameObject controller;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        StartCoroutine(Flash());

    }

    IEnumerator Flash()
    {
        Debug.Log("Allo");
        objectBonneReponse.GetComponent<Renderer>().material = objectBonneReponse.GetComponent<ListMaterial>().good;
        GetComponent<BoxCollider>().enabled = false;

        yield return new WaitForSeconds(0.5f);

        objectBonneReponse.GetComponent<Renderer>().material = objectBonneReponse.GetComponent<ListMaterial>().Aways;

        yield return new WaitForSeconds(0.2f);

        objectBonneReponse.GetComponent<Renderer>().material = objectBonneReponse.GetComponent<ListMaterial>().good;

        yield return new WaitForSeconds(0.5f);

        objectBonneReponse.GetComponent<Renderer>().material = objectBonneReponse.GetComponent<ListMaterial>().Aways;

        yield return new WaitForSeconds(0.2f);

        objectBonneReponse.GetComponent<Renderer>().material = objectBonneReponse.GetComponent<ListMaterial>().good;

        yield return new WaitForSeconds(0.5f);

        objectBonneReponse.GetComponent<Renderer>().material = objectBonneReponse.GetComponent<ListMaterial>().Aways;

        objectBonneReponse.GetComponent<HighlightObj>().destroyDust();
    }
}
