using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BoutonsMainMenu : MonoBehaviour {

    [SerializeField]
    GameObject under;

    [SerializeField]
    GameObject over;

    public GameObject Menu;
    public GameObject Transition;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnEnter()
    {
        under.transform.Translate(new Vector3(20, 0, 0));
        over.transform.Translate(new Vector3(20, 0, 0));
        under.GetComponent<Text>().fontSize = 40;
        over.GetComponent<Text>().fontSize = 40;
    }

    public void OnExit()
    {
        under.transform.Translate(new Vector3(-20, 0, 0));
        over.transform.Translate(new Vector3(-20, 0, 0));
        under.GetComponent<Text>().fontSize = 35;
        over.GetComponent<Text>().fontSize = 35;
    }

    public void OnClickCommencer()
    {
        Transition.transform.position = new Vector3(0, 0, 0);
        Transition.GetComponent<Animator>().enabled = true;
    }

    public void OnClickOptions()
    {

    }

    public void OnClickQuitter()
    {
        Application.Quit();
    }
}
