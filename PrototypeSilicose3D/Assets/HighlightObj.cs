using UnityEngine;
using System.Collections;

public class HighlightObj : MonoBehaviour {

    public GameObject dust;
    public GameObject panelBox;
    public GameObject controller;

    CarteCliqueControlleur ctrlClique;

    [Tooltip("Entre 0 et 13. mettre 0 si l'objet est une mauvaise reponse")]
    [Range(0, 12)]
    [SerializeField]
    int numeroCarte;

    [SerializeField]
    GameObject compteurClique;

    // Use this for initialization
    void Start () {
        ctrlClique = compteurClique.GetComponent<CarteCliqueControlleur>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseOver()
    {
        if (GetComponent<Collider>().enabled == true)
        {
            GetComponent<Renderer>().material = GetComponent<ListMaterial>().HighLight;
        }
    }

    void OnMouseExit()
    {
        if (GetComponent<Collider>().enabled == true)
        {
            GetComponent<Renderer>().material = GetComponent<ListMaterial>().Aways;
        }
    }

    void OnMouseDown()
    {
        if(numeroCarte > 0)
        {
            GetComponent<Renderer>().material = GetComponent<ListMaterial>().good;
            GetComponent<Collider>().enabled = false;

            GetComponent<Animator>().enabled = true;
            ctrlClique.joueurACliquer(numeroCarte);

            controller.GetComponent<main2Controller>().score++;
        }
        else
        {
            GetComponent<Renderer>().material = GetComponent<ListMaterial>().bad;
            GetComponent<Collider>().enabled = false;

            ctrlClique.joueurACliquer(numeroCarte);
        }

        panelBox.GetComponent<PanelController>().feedback(numeroCarte);
    }

    public void destroyDust()
    {
        Destroy(dust);
    }
}
