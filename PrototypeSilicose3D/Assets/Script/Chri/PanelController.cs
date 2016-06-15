using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PanelController : MonoBehaviour {

    [SerializeField]
    GameObject textField;

    [SerializeField]
    GameObject cardSpawnPoint;

    [SerializeField]
    GameObject[] tableauCarte;

    int carte = 20;
    Vector3 rotation;

    // Use this for initialization
    void Start () {
        rotation = new Vector3(0, 0, -12.5f);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SetText(string newText)
    {
        textField.GetComponent<Text>().text = newText;
    }

    public void SpawnCard()
    {
        if (carte < 15)
        {
            GameObject temp = (GameObject)Instantiate(tableauCarte[carte], new Vector3(cardSpawnPoint.transform.position.x, cardSpawnPoint.transform.position.y, cardSpawnPoint.transform.position.z), Quaternion.Euler(rotation));
            temp.transform.parent = cardSpawnPoint.transform;
            temp.transform.localScale = new Vector3(4, 4, 1);
        }
    }

    public void Apparait(int numCard)
    {
        carte = numCard;
        gameObject.GetComponent<Animator>().SetBool("apparait", true);   
    }

    public void Disparait()
    {
        gameObject.GetComponent<Animator>().SetBool("apparait", false);
    }
}
