using UnityEngine;
using System.Collections;

public class highlightNoDust : MonoBehaviour {

    public GameObject panelBox;


    [Tooltip("Entre 0 et 13. mettre 0 si l'objet est une mauvaise reponse")]
    [Range(0, 12)]
    [SerializeField]
    int numeroCarte;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

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
        if (numeroCarte > 0)
        {
            GetComponent<Renderer>().material = GetComponent<ListMaterial>().good;
            GetComponent<Collider>().enabled = false;

            //afficher feedback positif
            panelBox.GetComponent<PanelController>().feedback(numeroCarte);
        }
        else
        {
            GetComponent<Renderer>().material = GetComponent<ListMaterial>().bad;
            GetComponent<Collider>().enabled = false;

            //afficher feedback negatif
            panelBox.GetComponent<PanelController>().feedback();
        }


    }
}
