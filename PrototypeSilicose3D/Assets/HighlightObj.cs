using UnityEngine;
using System.Collections;

public class HighlightObj : MonoBehaviour {

    public GameObject dust;

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
        GetComponent<Renderer>().material = GetComponent<ListMaterial>().good;
        GetComponent<Collider>().enabled = false;

        GetComponent<Animator>().enabled = true;
        ctrlClique.joueurACliquer(numeroCarte);
    }

    public void destroyDust()
    {
        Destroy(dust);
    }
}
