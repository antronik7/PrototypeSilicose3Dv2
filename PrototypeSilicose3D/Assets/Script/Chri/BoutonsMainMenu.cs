using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BoutonsMainMenu : MonoBehaviour {

    [SerializeField]
    GameObject under;

    [SerializeField]
    GameObject over;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnEnter()
    {
        gameObject.transform.Translate(new Vector3(25, 0, 0));
        under.GetComponent<Text>().fontSize = 38;
        over.GetComponent<Text>().fontSize = 38;
    }

    public void OnExit()
    {
        gameObject.transform.Translate(new Vector3(-25, 0, 0));
        under.GetComponent<Text>().fontSize = 35;
        over.GetComponent<Text>().fontSize = 35;
    }

    public void OnClickCommencer()
    {

    }

    public void OnClickOptions()
    {

    }

    public void OnClickQuitter()
    {
        Application.Quit();
    }
}
