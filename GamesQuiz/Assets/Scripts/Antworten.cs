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
    public static int Fragennum = 0;
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
      "2", "3","4", 
      "Antwort 1 Frage 2", "Antwort 2 Frage 2","Antwort 3 Frage 2",
      "Antwort 1 Frage 3", "Antwort 2 Frage 3","Antwort 3 Frage 3",
      "Antwort 1 Frage 4", "Antwort 2 Frage 4","Antwort 3 Frage 4",
      "Antwort 1 Frage 5", "Antwort 2 Frage 5","Antwort 3 Frage 5",
      "Antwort 1 Frage 6", "Antwort 2 Frage 6","Antwort 3 Frage 6",
      "Antwort 1 Frage 7", "Antwort 2 Frage 7","Antwort 3 Frage 7",
      "Antwort 1 Frage 8", "Antwort 2 Frage 8","Antwort 3 Frage 8",
      "Antwort 1 Frage 9", "Antwort 2 Frage 9","Antwort 3 Frage 9",
      "Antwort 1 Frage 10", "Antwort 2 Frage 10","Antwort 3 Frage 10",
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
        false,false,true,


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
        Debug.Log("J: " + Player.j);
        //Player.PlayerScore1.fillAmount = fillAmountPlayer1 ;


        int i = Player.j;  // counter
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
                if (Fragen.Fragennum == 9)
                {
                    checkFisnish = true;
                    WinLoose();
                    BackgroundMusic.Stop();
                }
                else
                {
                    BackgroundMusic.Stop();
                    SoundManager();
                    Player.PlayerScore1.enabled = true;
                    Player.PlayerScore2.enabled = true;
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
                if (Fragen.Fragennum == 9)
                {
                    checkFisnish = true;
                    WinLoose();
                    BackgroundMusic.Stop();
                }
                else
                {
                    BackgroundMusic.Stop();
                    SoundManager();
                    Player.PlayerScore1.enabled = true;
                    Player.PlayerScore2.enabled = true;

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
            if (Fragen.Fragennum == 9)
            {
                checkFisnish = true;
                WinLoose();
                BackgroundMusic.Stop();
            }
            else
            {
                BackgroundMusic.Stop();
                SoundManager();
                Player.PlayerScore1.enabled = true;
                Player.PlayerScore2.enabled = true;
                RichtigFalsch1.enabled = true;
                RichtigFalsch2.enabled = true;
            }


            cTimer -= Time.deltaTime; 
            if(cTimer <=0)      
            {
                Fragen.Fragennum++;
                SceneManager.LoadScene("Fragen");
            }
        }

        if (Input.GetKey(KeyCode.Space) && (currentScene.name == "Antworten"))
        {
            Fragen.Fragennum++;
            SceneManager.LoadScene("Fragen");
        }
    }
  

    void WinLoose ()
    {
        if(Player.p1Score > Player.p2Score)
        {
            RichtigFalsch2.text = "LOOSER";
            RichtigFalsch1.text = "WINNER";
            RichtigFalsch1.enabled = true;
            RichtigFalsch2.enabled = true;

            Applaus.Play();
        }
        if (Player.p1Score < Player.p2Score)
        {
            RichtigFalsch1.text = "LOOSER";
            RichtigFalsch2.text = "WINNER";
            RichtigFalsch1.enabled = true;
            RichtigFalsch2.enabled = true;
            Applaus.Play();
        }
        if  (Player.p1Score == Player.p2Score)
        {
            RichtigFalsch1.text = "EQUAL";
            RichtigFalsch2.text = "EQUAL";
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
