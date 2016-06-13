using UnityEngine;
using System.Collections;

public class CubeOnMouseOverHighlight : MonoBehaviour {

    

    public GameObject object1;
    public GameObject object2;
    public GameObject object3;
    public GameObject object4;
    public GameObject object5;
    public GameObject object6;

    [Tooltip("Cocher si l'objet doit etre cliquer pour gagner")]
    [SerializeField] bool GoodAwnser;

    CarteCliqueControlleur ctrlClique;

    [Tooltip("Entre 0 et 13. mettre 0 si l'objet est une mauvaise reponse")]
    [Range(0, 12)]
    [SerializeField]
    int numeroCarte;

    [SerializeField]
    GameObject compteurClique;

    // Use this for initialization
    void Start()
    {
        ctrlClique = compteurClique.GetComponent<CarteCliqueControlleur>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseOver()
    {
        if (GetComponent<Collider>().enabled == true)
        {
            object1.GetComponent<Renderer>().material = object1.GetComponent<ListMaterial>().HighLight;
            object2.GetComponent<Renderer>().material = object2.GetComponent<ListMaterial>().HighLight;
            object3.GetComponent<Renderer>().material = object3.GetComponent<ListMaterial>().HighLight;
            object4.GetComponent<Renderer>().material = object4.GetComponent<ListMaterial>().HighLight;
            object5.GetComponent<Renderer>().material = object5.GetComponent<ListMaterial>().HighLight;
            object6.GetComponent<Renderer>().material = object6.GetComponent<ListMaterial>().HighLight;
        }
    }

    void OnMouseExit()
    {
        if (GetComponent<Collider>().enabled == true)
        {
            object1.GetComponent<Renderer>().material = object1.GetComponent<ListMaterial>().Aways;
            object2.GetComponent<Renderer>().material = object2.GetComponent<ListMaterial>().Aways;
            object3.GetComponent<Renderer>().material = object3.GetComponent<ListMaterial>().Aways;
            object4.GetComponent<Renderer>().material = object4.GetComponent<ListMaterial>().Aways;
            object5.GetComponent<Renderer>().material = object5.GetComponent<ListMaterial>().Aways;
            object6.GetComponent<Renderer>().material = object6.GetComponent<ListMaterial>().Aways;
        }
    }

    void OnMouseDown()
    {
        if (GoodAwnser)
        {
            object1.GetComponent<Renderer>().material = object1.GetComponent<ListMaterial>().good;
            object2.GetComponent<Renderer>().material = object2.GetComponent<ListMaterial>().good;
            object3.GetComponent<Renderer>().material = object3.GetComponent<ListMaterial>().good;
            object4.GetComponent<Renderer>().material = object4.GetComponent<ListMaterial>().good;
            object5.GetComponent<Renderer>().material = object5.GetComponent<ListMaterial>().good;
            object6.GetComponent<Renderer>().material = object6.GetComponent<ListMaterial>().good;

            object1.GetComponent<Collider>().enabled = false;
            object2.GetComponent<Collider>().enabled = false;
            object3.GetComponent<Collider>().enabled = false;
            object4.GetComponent<Collider>().enabled = false;
            object5.GetComponent<Collider>().enabled = false;
            object6.GetComponent<Collider>().enabled = false;
        }
        else
        {
            object1.GetComponent<Renderer>().material = object1.GetComponent<ListMaterial>().bad;
            object2.GetComponent<Renderer>().material = object2.GetComponent<ListMaterial>().bad;
            object3.GetComponent<Renderer>().material = object3.GetComponent<ListMaterial>().bad;
            object4.GetComponent<Renderer>().material = object4.GetComponent<ListMaterial>().bad;
            object5.GetComponent<Renderer>().material = object5.GetComponent<ListMaterial>().bad;
            object6.GetComponent<Renderer>().material = object6.GetComponent<ListMaterial>().bad;

            object1.GetComponent<Collider>().enabled = false;
            object2.GetComponent<Collider>().enabled = false;
            object3.GetComponent<Collider>().enabled = false;
            object4.GetComponent<Collider>().enabled = false;
            object5.GetComponent<Collider>().enabled = false;
            object6.GetComponent<Collider>().enabled = false;
        }

        ctrlClique.joueurACliquer(numeroCarte);
    }
}
