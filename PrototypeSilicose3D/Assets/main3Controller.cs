using UnityEngine;
using System.Collections;

public class main3Controller : MonoBehaviour {

    [SerializeField]
    GameObject panelBox;

    // Use this for initialization
    void Start()
    {
        panelBox.GetComponent<PanelController>().SetText("Aidez Gaston a suivre les bonnes mesures individuelles de securites tout au long de sa journee de travail. Dans chaque situation, cliquez sur la bonne mesure individuelle. Aidez-vous avec le titre en haut de l'ecran.", "Mesures individuelles");
        panelBox.GetComponent<PanelController>().Apparait(13);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
