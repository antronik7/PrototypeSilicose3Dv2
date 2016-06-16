using UnityEngine;
using System.Collections;

public class CubeOnMouseOverHighlight : MonoBehaviour {

    

    public GameObject object1;
    public GameObject object2;
    public GameObject object3;
    public GameObject object4;
    public GameObject object5;

    [SerializeField]
    GameObject panelBox;

    [SerializeField][TextArea]
    string textAAfficher;

    CarteCliqueControlleur ctrlClique;

    [Tooltip("Entre 0 et 12. mettre 0 si l'objet est une mauvaise reponse")]
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
        }
    }

    void OnMouseDown()
    {
        if (numeroCarte > 0)
        {
            gameObject.GetComponent<Collider>().enabled = false;
            object1.GetComponent<Renderer>().material = object1.GetComponent<ListMaterial>().good;
            object2.GetComponent<Renderer>().material = object2.GetComponent<ListMaterial>().good;
            object3.GetComponent<Renderer>().material = object3.GetComponent<ListMaterial>().good;
            object4.GetComponent<Renderer>().material = object4.GetComponent<ListMaterial>().good;
            object5.GetComponent<Renderer>().material = object5.GetComponent<ListMaterial>().good;
        }
        else
        {
            gameObject.GetComponent<Collider>().enabled = false;
            object1.GetComponent<Renderer>().material = object1.GetComponent<ListMaterial>().bad;
            object2.GetComponent<Renderer>().material = object2.GetComponent<ListMaterial>().bad;
            object3.GetComponent<Renderer>().material = object3.GetComponent<ListMaterial>().bad;
            object4.GetComponent<Renderer>().material = object4.GetComponent<ListMaterial>().bad;
            object5.GetComponent<Renderer>().material = object5.GetComponent<ListMaterial>().bad;
        }


        string Letitre;

        if(numeroCarte > 0)
        {
            Letitre = "Bien joué!";
            GameManager.instance.Score++;
        }
        else
        {
            Letitre = "Oups!";
            GameManager.instance.NegatifScore++;
        }

        panelBox.GetComponent<PanelController>().SetText(textAAfficher, Letitre);
        panelBox.GetComponent<PanelController>().Apparait(numeroCarte);
        ctrlClique.joueurACliquer(numeroCarte);
    }
}
