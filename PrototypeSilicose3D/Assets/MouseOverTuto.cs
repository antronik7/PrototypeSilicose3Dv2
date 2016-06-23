using UnityEngine;
using System.Collections;

public class MouseOverTuto : MonoBehaviour {

    public GameObject object1;
    public GameObject object2;
    public GameObject object3;
    public GameObject object4;
    public GameObject object5;

    [SerializeField]
    GameObject panelBox;

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
        
            gameObject.GetComponent<Collider>().enabled = false;
            object1.GetComponent<Renderer>().material = object1.GetComponent<ListMaterial>().good;
            object2.GetComponent<Renderer>().material = object2.GetComponent<ListMaterial>().good;
            object3.GetComponent<Renderer>().material = object3.GetComponent<ListMaterial>().good;
            object4.GetComponent<Renderer>().material = object4.GetComponent<ListMaterial>().good;
            object5.GetComponent<Renderer>().material = object5.GetComponent<ListMaterial>().good;
            panelBox.GetComponent<PanelController>().feedback(13);


        string Letitre;


            Letitre = "Bien joué!";

        panelBox.GetComponent<PanelController>().SetText("Vous avez termine le tutorial, vous pouvez maintenant passer au niveau suivant", Letitre);
        panelBox.GetComponent<PanelController>().Apparait(13);
    }
}
