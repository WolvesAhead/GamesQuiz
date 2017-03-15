using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Antworten : MonoBehaviour {

    public Text txt1;
    public Text txt2;
    public Text txt3;
    public Text txt1_2;
    public Text txt2_2;
    public Text txt3_2;

    bool left;
    bool up;
    bool right;
    bool checkFisnish = false;
    //public static int Fragennum = Fragen.Fragennum;
    public static float fillAmountPlayer1 = 0;
    private bool canClick;
    private bool canClick2;
    private float aTimer = 10;
    private float bTimer = 10;
    private float cTimer = 5;
    public Image TimerBlue;
    public Image TimerRed;
    public Text RichtigFalsch1;
    public Text RichtigFalsch2;
    public AudioSource BackgroundMusic;
    public AudioSource Applaus;
    public AudioSource Boo;



    string[] AntwortenArray = 
    
    {
      "4", "2","5", 
      "874", "365","265",
      "Wario", "Plumberman","Mr. Video",
      "Playstation 2", "Nintendo Ds","Game Boy",
      "Ein Auto", "Ein Gen","Schuhe",
      "4", "8","26",
      "Agro", "Epona","Wanda",
      "Dante & Virgil", "Ebony & Ivory","Black & White",
      "Pokémon Gelb", "Tetris","Wii Sports",
      "801", "1024","637",
    };


     public static bool[] LösungenArray =

    {
        true,false,false,
        false,true,false,
        false,false,true,
        true,false,false,
        false,true,false,
        false,false,true,
        true,false,false,
        false,true,false,
        false,false,true,
        true,false,false,


      // Lösungen ;
    };

    void Start()
    {
        TimerBlue.fillAmount = 1f;
        TimerRed.fillAmount = 1f;
        Player.PlayerScore1.fillAmount = Player.PlayerScore1.fillAmount;
        Player.PlayerScore2.fillAmount = Player.PlayerScore2.fillAmount;
        //Player.PlayerScore1.enabled = false;



    } 
    // Use this for initialization
    void Awake () {
        //Debug.Log("J: " + Player.j);
        //Player.PlayerScore1.fillAmount = fillAmountPlayer1 ;


           int i = (Fragen.Fragennum * 3);  // counter
            txt1.text = AntwortenArray[i];
            txt2.text = AntwortenArray[i+1];
            txt3.text = AntwortenArray[i+2];
            txt1_2.text = AntwortenArray[i];
            txt2_2.text = AntwortenArray[i + 1];
            txt3_2.text = AntwortenArray[i + 2];

            left = LösungenArray[i];
            up = LösungenArray[i+1];
            right = LösungenArray[i+2];


        Debug.Log("i : " + i);
        Debug.Log("left"+left);
        Debug.Log("up" + up);
        Debug.Log("right" + right);
        Player.j += 3;
        canClick = true;
        canClick2 = true;
    }
  

    // Update is called once per frame
    void Update () {
        Scene currentScene = SceneManager.GetActiveScene();

        Debug.Log("Fragennumm : " + Fragen.Fragennum);
        Debug.Log("Counter : " + Fragen.counter);
        if (Input.GetKeyDown(KeyCode.LeftArrow) && (currentScene.name == "Antworten") && (left == true) && canClick == true)

        {

            Player.p1Score += 1;
            RichtigFalsch1.text = "RICHTIG";
            Debug.Log("Richtig :" + Player.p1Score + " Punkte");
            Player.PlayerScore1.fillAmount += (Player.p1Score * 0.1f) ;
            //fillAmountPlayer1 = Player.PlayerScore1.fillAmount;
            canClick = false;

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && (currentScene.name == "Antworten") && (left == false) && canClick == true)
        {
            Debug.Log("Falsch !");
            RichtigFalsch1.text = "FALSCH";
            canClick = false;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && (currentScene.name == "Antworten") && (up == true) && canClick == true)

        {
            Player.p1Score += 1;
            Player.PlayerScore1.fillAmount += (Player.p1Score * 0.1f);
            //fillAmountPlayer1 = Player.PlayerScore1.fillAmount;
            RichtigFalsch1.text = "RICHTIG";
            Debug.Log("Richtig :" + Player.p1Score + " Punkte");
            canClick = false;

        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && (currentScene.name == "Antworten") && (up == false) && canClick == true)
        {
            Debug.Log("Falsch !");
            RichtigFalsch1.text = "FALSCH";
            canClick = false;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && (currentScene.name == "Antworten") && (right == true) && canClick == true)

        {
            Player.p1Score += 1;
            Player.PlayerScore1.fillAmount += (Player.p1Score * 0.1f);
           // fillAmountPlayer1 = Player.PlayerScore1.fillAmount;
            Debug.Log("Richtig :" + Player.p1Score + " Punkte");
            RichtigFalsch1.text = "RICHTIG";
            canClick = false;

        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && (currentScene.name == "Antworten") && (right == false) && canClick == true)
        {
            Debug.Log("Falsch !");
            RichtigFalsch1.text = "FALSCH";
            canClick = false;
        }


        //player2

        if (Input.GetKeyDown(KeyCode.A) && (currentScene.name == "Antworten") && (left==true) && canClick2 == true)

        {
            Player.p2Score += 1;
            Player.PlayerScore2.fillAmount += (Player.p2Score * 0.1f);
            RichtigFalsch2.text = "RICHTIG";
            Debug.Log("Richtig :" + Player.p2Score + " Punkte");
            canClick2 = false;

        }
        if (Input.GetKeyDown(KeyCode.A) && (currentScene.name == "Antworten") && (left == false) && canClick2 == true)
        {
            Debug.Log("Falsch !");
            RichtigFalsch2.text = "FALSCH";
            canClick2 = false;
        }
        if (Input.GetKeyDown(KeyCode.W) && (currentScene.name == "Antworten") && (up == true) && canClick2 == true)

        {
            Player.p2Score += 1;
            Player.PlayerScore2.fillAmount += (Player.p2Score * 0.1f);
            RichtigFalsch2.text = "RICHTIG";
            Debug.Log("Richtig :" + Player.p2Score + " Punkte");
            canClick2 = false;

        }
        if (Input.GetKeyDown(KeyCode.W) && (currentScene.name == "Antworten") && (up == false) && canClick2 == true)
        {
            Debug.Log("Falsch !");
            RichtigFalsch2.text = "FALSCH";
            canClick2 = false;
        }
        if (Input.GetKeyDown(KeyCode.D) && (currentScene.name == "Antworten") && (right == true) && canClick2 == true)

        {
            Player.p2Score += 1;
            Player.PlayerScore2.fillAmount += (Player.p2Score * 0.1f);
            RichtigFalsch2.text = "RICHTIG";
            Debug.Log("Richtig :"+Player.p2Score+" Punkte" );
            canClick2 = false;

        }
        if (Input.GetKeyDown(KeyCode.D) && (currentScene.name == "Antworten") && (right == false) && canClick2 == true)
        {
            Debug.Log("Falsch !");
            RichtigFalsch2.text = "FALSCH";
            canClick2 = false;
        }


        if (canClick == true )
        {

            //Player.PlayerScore1.enabled = true;
            aTimer -= Time.deltaTime;
            if (aTimer <= 0)
            {
                Fragen.counter++;
                if (Fragen.counter == 9)
                {
                    checkFisnish = true;
                    WinLose();
                    BackgroundMusic.Stop();
                    SceneManager.LoadScene("Menu");
                }
                else
                {
                    BackgroundMusic.Stop();
                    SoundManager();
                    Player.PlayerScore1.enabled = true;
                    Player.PlayerScore2.enabled = true;
                    GameObject.Find("Directional Light").GetComponent<Light>().enabled = false;
                    RichtigFalsch1.enabled = true;
                    RichtigFalsch2.enabled = true;
                    SceneManager.LoadScene("Fragen");
                }
               
            }
        }

        if (canClick2 == true )
        {

           // Player.PlayerScore1.enabled = true;
            bTimer -= Time.deltaTime;
            if (bTimer <= 0)
            {
                Fragen.counter++;
                if (Fragen.counter == 9)
                {
                    checkFisnish = true;
                    WinLose();
                    BackgroundMusic.Stop();
                    SceneManager.LoadScene("Menu");
                }
                else
                {
                    BackgroundMusic.Stop();
                    SoundManager();
                    Player.PlayerScore1.enabled = true;
                    Player.PlayerScore2.enabled = true;
                    GameObject.Find("Directional Light").GetComponent<Light>().enabled = false;
                    RichtigFalsch1.enabled = true;
                    RichtigFalsch2.enabled = true;
                    SceneManager.LoadScene("Fragen");
                  
                }
                
            }
        }
        TimerBlue.fillAmount = aTimer/10;
        TimerRed.fillAmount = bTimer/10;

        if(canClick == false && canClick2 == false)
        {

            if (Fragen.counter == 9)
            {
                checkFisnish = true;
                WinLose();
                BackgroundMusic.Stop();
                SceneManager.LoadScene("Menu");

            }
            else
            {
                BackgroundMusic.Stop();
                SoundManager();
                Player.PlayerScore1.enabled = true;
                Player.PlayerScore2.enabled = true;
                GameObject.Find("Directional Light").GetComponent<Light>().enabled = false;
                RichtigFalsch1.enabled = true;
                RichtigFalsch2.enabled = true;
            }

            cTimer -= Time.deltaTime; 
            if(cTimer <=0)      
            {
              
                Fragen.counter++;
                SceneManager.LoadScene("Fragen");
            }
        }

        if (Input.GetKey(KeyCode.Space) && (currentScene.name == "Antworten"))
        {
            Fragen.counter++;
            SceneManager.LoadScene("Fragen");
        }
    }
  

    void WinLose ()
    {
        if(Player.p1Score > Player.p2Score)
        {
            RichtigFalsch2.text = "LOSER";
            RichtigFalsch1.text = "WINNER";
            RichtigFalsch1.enabled = true;
            RichtigFalsch2.enabled = true;
            GameObject.Find("Directional Light").GetComponent<Light>().enabled = false;


            Applaus.Play();
        }
        if (Player.p1Score < Player.p2Score)
        {
            RichtigFalsch1.text = "LOSER";
            RichtigFalsch2.text = "WINNER";
            GameObject.Find("Directional Light").GetComponent<Light>().enabled = false;
            RichtigFalsch1.enabled = true;
            RichtigFalsch2.enabled = true;
            Applaus.Play();
        }
        if  (Player.p1Score == Player.p2Score)
        {
            RichtigFalsch1.text = "UNENTSCHIEDEN";
            RichtigFalsch2.text = "UNENTSCHIEDEN";
            GameObject.Find("Directional Light").GetComponent<Light>().enabled = false;
            RichtigFalsch1.enabled = true;
            RichtigFalsch2.enabled = true;
            Applaus.Play();
        }
    }




    void SoundManager ()
    {
        if (RichtigFalsch1.text.Contains("RICHTIG"))
        {
            Applaus.Play();
        }
        if (RichtigFalsch2.text == "RICHTIG")
        {
            Applaus.Play();
        }
        if (RichtigFalsch1.text == "FALSCH" && RichtigFalsch2.text == "FALSCH")
        {
            Boo.Play();
        }
    }
}
