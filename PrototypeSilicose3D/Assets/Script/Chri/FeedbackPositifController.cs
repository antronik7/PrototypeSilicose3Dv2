using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FeedbackPositifController : MonoBehaviour {

    [SerializeField]
    GameObject thumbs;

    [SerializeField]
    GameObject spawnPos;

    Image imgThumbs;
    Image imgCarte;

    GameObject carteAfficher;
    bool estAfficher = false;
    private float translation = 0.2f;
    Vector3 rotation;

    // Use this for initialization
    void Start () {
        rotation = new Vector3(0, 0, -12.5f);
        imgThumbs = thumbs.GetComponent<Image>();
	
	}
	
	// Update is called once per frame
	void Update () {

        if(estAfficher)
        {
            translation = Time.deltaTime * 2;
            transform.Translate(0, translation, 0);

            imgThumbs.color = new Vector4(imgThumbs.color.r, imgThumbs.color.g, imgThumbs.color.b, imgThumbs.color.a - 0.02f);
            imgCarte.color = new Vector4(imgCarte.color.r, imgCarte.color.g, imgCarte.color.b, imgCarte.color.a - 0.02f);

            if (imgThumbs.color.a == 0)
            {
                Destroy(gameObject);
            }
        }
	
	}

    public void AfficherCarte(GameObject carte)
    {
        carteAfficher = (GameObject)Instantiate(carte, spawnPos.transform.position, Quaternion.Euler(rotation));
        carteAfficher.transform.SetParent(gameObject.transform);
        carteAfficher.transform.localScale = new Vector3(2.5f, 2.5f, 1);
        imgCarte = carteAfficher.GetComponent<Image>();
        estAfficher = true;
    }
}
