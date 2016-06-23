using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;

    public float time = 300;
    public string timeString;
    public bool GameStart = false;
    public int Score = 0;
    public int NegatifScore = 0;
    public GameObject panelBox;
    public GameObject Hud;

    //Awake is always called before any Start functions
    void Awake()
    {
        //Check if instance already exists
        if (instance == null)

            //if not, set instance to this
            instance = this;

        //If instance already exists and it's not this:
        else if (instance != this)

            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);

        //Sets this to not be destroyed when reloading scene
        DontDestroyOnLoad(gameObject);
    }

    // Use this for initialization
    void Start () {
	    timeString = string.Format("{0:00}:{1:00}", (int)time / 60, (int)time % 60);
    }
	
	// Update is called once per frame
	void Update () {

        if(Score == 12 - NegatifScore)
        {
            GameStart = false;
            panelBox.GetComponent<PanelController>().SetText("Bravo vous avez terminé le premier niveau. Appuyez sur continuer pour passer au suivant!", "Score : " + Score + "/12");
            panelBox.GetComponent<PanelController>().Apparait(13);
        }

        if(GameStart)
        {
            time -= Time.deltaTime;
            timeString = string.Format("{0:00}:{1:00}", (int)time / 60, (int)time % 60);
        }
	
	}

    public void StartGame()
    {
        GameStart = true;
        
        panelBox.GetComponent<PanelController>().SetText("Trouvez et identifier les 12 travailleurs qui ne travaillent pas selon les normes de securite. Chercherz bien, certains sont bien cache. Bonne chance!", "Identification");
        panelBox.GetComponent<PanelController>().Apparait(13);

        Camera.main.GetComponent<cameraRotation>().enabled = true;
        Hud.SetActive(true);
    }
}
