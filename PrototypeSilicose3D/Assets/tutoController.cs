using UnityEngine;
using System.Collections;

public class tutoController : MonoBehaviour {

    [SerializeField]
    GameObject panelBox;

    // Use this for initialization
    void Start () {
        panelBox.GetComponent<PanelController>().SetText("Trouvez et identifier les travailleurs qui travaillent selon les normes de sécurité afin de compléter votre paquet de carte. Évitez les travailleurs non sécuritaires car ils vous feront perdre des points. Utiliser le clique droit pour déplacer la caméra avec la souris. Vous pouvez également zoomer en utilisant la roulette. Bonne chance!", "Tutorial");
        panelBox.GetComponent<PanelController>().Apparait(13);

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
