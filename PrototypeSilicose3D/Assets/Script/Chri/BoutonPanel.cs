using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BoutonPanel : MonoBehaviour {

    [SerializeField]
    GameObject under;

    [SerializeField]
    GameObject over;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnEnter()
    {
        under.GetComponent<Text>().fontSize = 35;
        over.GetComponent<Text>().fontSize = 35;
    }

    public void OnExit()
    {
        under.GetComponent<Text>().fontSize = 30;
        over.GetComponent<Text>().fontSize = 30;
    }

    public void OnClick()
    {
        gameObject.GetComponent<PanelController>().Disparait();
    }
}
