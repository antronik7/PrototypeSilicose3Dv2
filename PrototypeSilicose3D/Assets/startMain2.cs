using UnityEngine;
using System.Collections;

public class startMain2 : MonoBehaviour {

    public GameObject panelBox;
    // Use this for initialization
    void Start () {
        panelBox.GetComponent<PanelController>().SetText("Trouvez et cliquez sur les methodes de controle dans les 12 mise en situation. Attention, il y des pieges pour vous melanger!", "Methode controle");
        panelBox.GetComponent<PanelController>().Apparait(13);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
