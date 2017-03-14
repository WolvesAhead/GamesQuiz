using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    public static int j = 0 ;
    private float qTimer = 10;
    private bool timeOut = false;
    private bool player1first = false;
    private bool player2first = false;
    public Image TimerBlue;
    public Image TimerRed;
    public static int p1Score;
    public static int p2Score;
    public static Image PlayerScore1;
    public static Image PlayerScore2;
    public static int Player2Score;





    // Use this for initialization
    void Start () {
        PlayerScore1 = GameObject.Find("PlayerScore1").GetComponent<Image>();
        PlayerScore2 = GameObject.Find("PlayerScore2").GetComponent<Image>();
        //TimerBlue_gb.SetActive(false);
        //TimerRed_gb.SetActive(false);

    }

    private void Awake()
    {
        // PlayerScore1 = GameObject.Find("PlayerScore1").GetComponent<Image>();
        //Antworten.fillAmountPlayer1 = PlayerScore1.fillAmount;
    }


    // Update is called once per frame
    void Update () {
        Scene currentScene = SceneManager.GetActiveScene();

      


        if (Input.GetKeyDown(KeyCode.UpArrow) && (currentScene.name == "Fragen") && player2first == !true)
        {
             player1first = true;
        }

        if (Input.GetKeyDown(KeyCode.W) && (currentScene.name == "Fragen")&& player1first == !true)
        {
            player2first = true;
        }


        if (player1first == true &&(currentScene.name == "Fragen"))
        {
            
           
         
            qTimer -= Time.deltaTime;
            TimerRed.fillAmount = qTimer/ 10 ;
            
            if (qTimer <= 0)
            {
                Debug.Log(TimerRed.fillAmount);
                Debug.Log("Timer zuende");
                timeOut = true;
                SceneManager.LoadScene("Antworten");
            }
            Debug.Log("Player 1 zuerst");
            if (Input.GetKey(KeyCode.W) && (currentScene.name == "Fragen") && timeOut == false)

            {
                TimerBlue.fillAmount = 0;
                SceneManager.LoadScene("Antworten");


            }
          
          

        }
       

        if (player2first == true && (currentScene.name == "Fragen"))

        {
           
            qTimer -= Time.deltaTime;
            TimerBlue.fillAmount = qTimer / 10 ;
            TimerRed.fillAmount = 0;
            if (qTimer <= 0)
            {
              
                Debug.Log("Timer zuende");
                timeOut = true;
                SceneManager.LoadScene("Antworten");

            }
            Debug.Log("Player 2 zuerst");
            if (Input.GetKey(KeyCode.UpArrow) && (currentScene.name == "Fragen") && timeOut == false)

            {

                SceneManager.LoadScene("Antworten");
            }


        }
       




    }

    
}
