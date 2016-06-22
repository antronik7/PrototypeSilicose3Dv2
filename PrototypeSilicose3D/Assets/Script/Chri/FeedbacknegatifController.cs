using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FeedbacknegatifController : MonoBehaviour {

    [SerializeField]
    GameObject thumbs;

    [SerializeField]
    GameObject carte;

    Image imgThumbs;
    Image imgCarte;

    private float translation = 50f;

    // Use this for initialization
    void Start()
    {

        imgThumbs = thumbs.GetComponent<Image>();
        imgCarte = carte.GetComponent<Image>();

    }

    // Update is called once per frame
    void Update()
    {
            translation = Time.deltaTime * 2;
            gameObject.transform.Translate(0, translation, 0);

            imgThumbs.color = new Vector4(imgThumbs.color.r, imgThumbs.color.g, imgThumbs.color.b, imgThumbs.color.a - 0.01f);
            imgCarte.color = new Vector4(imgCarte.color.r, imgCarte.color.g, imgCarte.color.b, imgCarte.color.a - 0.01f);

            if (imgThumbs.color.a <= 0)
            {
                Destroy(gameObject);
            }
     
    }

}
