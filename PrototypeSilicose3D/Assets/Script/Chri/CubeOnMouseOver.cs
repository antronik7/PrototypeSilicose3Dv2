using UnityEngine;
using System.Collections;

public class CubeOnMouseOver : MonoBehaviour {

    [SerializeField] Material good;
    [SerializeField] Material bad;
    [SerializeField] Material Aways;
    [SerializeField] GameObject compteurClique;
    CarteCliqueControlleur ctrlClique;

    [Tooltip("Entre 0 et 13. mettre 0 si l'objet est une mauvaise reponse")][Range(0,12)][SerializeField] int numeroCarte;

    // Use this for initialization
    void Start () {
        ctrlClique = compteurClique.GetComponent<CarteCliqueControlleur>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseOver() {

        GetComponent<Renderer>().material.color = new Color(1f,1f,1f);
        //GetComponent<Renderer>().material = Over;
    }

    void OnMouseExit()
    {
        if(GetComponent<Collider>().enabled == true)
        { 
            GetComponent<Renderer>().material = Aways;
        }   
    }

    void OnMouseDown()
    {
        if (numeroCarte != 0)
        {
            GetComponent<Renderer>().material = good;
            GetComponent<Collider>().enabled = false;
        }
        else
        {
            GetComponent<Renderer>().material = bad;
            GetComponent<Collider>().enabled = false;
        }

        ctrlClique.joueurACliquer(numeroCarte);
    }
}
