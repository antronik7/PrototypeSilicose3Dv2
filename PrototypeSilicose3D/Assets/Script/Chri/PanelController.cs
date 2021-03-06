﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PanelController : MonoBehaviour {

    [SerializeField]
    GameObject feedbackNeg;

    [SerializeField]
    GameObject feedbackPos;

    [SerializeField]
    GameObject textField;

    public GameObject Titre;

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

    public void SetText(string newText, string LeTitre)
    {
        textField.GetComponent<Text>().text = newText;
        Titre.GetComponent<Text>().text = LeTitre;
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

    //feedback negatif
    public void feedback()
    {
        GameObject temp = (GameObject)Instantiate(feedbackNeg, Input.mousePosition, Quaternion.identity);
        temp.transform.SetParent(gameObject.transform.parent);
    }


    //feedback positif
    public void feedback(int numCard)
    {
        GameObject temp = (GameObject)Instantiate(feedbackPos, Input.mousePosition, Quaternion.identity);
        temp.transform.SetParent(gameObject.transform.parent);
        temp.GetComponent<FeedbackPositifController>().AfficherCarte(tableauCarte[numCard]);
    }
}
