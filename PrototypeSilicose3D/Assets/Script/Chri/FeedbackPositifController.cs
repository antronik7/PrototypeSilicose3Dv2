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
    bool firstTime = true;
    private float translation = 50f;

    // Use this for initialization
    void Start () {
        imgThumbs = thumbs.GetComponent<Image>();
	
	}
	
	// Update is called once per frame
	void Update () {

        if(estAfficher)
        {
            if(firstTime)
            {
                StartCoroutine(Delay());
            }
            else
            {
                translation = Time.deltaTime * 50;
                gameObject.transform.Translate(0, translation, 0);

                imgThumbs.color = new Vector4(imgThumbs.color.r, imgThumbs.color.g, imgThumbs.color.b, imgThumbs.color.a - 0.01f);
                imgCarte.color = new Vector4(imgCarte.color.r, imgCarte.color.g, imgCarte.color.b, imgCarte.color.a - 0.01f);

                if (imgThumbs.color.a <= 0)
                {
                    Destroy(gameObject);
                }
            }
            
        }
	
	}

    public void AfficherCarte(GameObject carte)
    {
        carteAfficher = (GameObject)Instantiate(carte, spawnPos.transform.position, Quaternion.identity);
        carteAfficher.transform.SetParent(gameObject.transform);
        carteAfficher.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, -12.5f));
        carteAfficher.transform.localScale = new Vector3(2.5f, 2.5f, 1);
        imgCarte = carteAfficher.GetComponent<Image>();
        estAfficher = true;
    }

    IEnumerator Delay()
    {
        print(Time.time);
        yield return new WaitForSeconds(0.5f);
        print(Time.time);
        firstTime = false;
    }
}
