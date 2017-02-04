using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Antworten : MonoBehaviour {

    public Text txt1;
    public Text txt2;
    public Text txt3;
    bool left;
    bool up;
    bool right;
    public static int Fragennum = 0;
    private bool canClick;





    string[] AntwortenArray = 
    
    {
      "Antwort 1 Frage 1", "Antwort 2 Frage 1","Antwort 3 Frage 1", 
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


    // Use this for initialization
    void Awake () {
        Debug.Log("J: " + Player.j);
        int i = Player.j;  // counter
            txt1.text = AntwortenArray[i];
            txt2.text = AntwortenArray[i+1];
            txt3.text = AntwortenArray[i+2];
            left = LösungenArray[i];
            up = LösungenArray[i+1];
            right = LösungenArray[i+2];


        Debug.Log("i : " + i);
        Debug.Log("left"+left);
        Debug.Log("up" + up);
        Debug.Log("right" + right);
        Player.j += 3;
        canClick = true;
    }
  

    // Update is called once per frame
    void Update () {
        Scene currentScene = SceneManager.GetActiveScene();


        if (Input.GetKeyDown(KeyCode.LeftArrow) && (currentScene.name == "Antworten") && (left==true) && canClick == true)

        {

            Debug.Log("Richtig !");
            canClick = false;

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && (currentScene.name == "Antworten") && (left == false) && canClick == true)
        {
            Debug.Log("Falsch !");
            canClick = false;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && (currentScene.name == "Antworten") && (up == true) && canClick == true)

        {

            Debug.Log("Richtig !");
            canClick = false;

        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && (currentScene.name == "Antworten") && (up == false) && canClick == true)
        {
            Debug.Log("Falsch !");
            canClick = false;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && (currentScene.name == "Antworten") && (right == true) && canClick == true)

        {

            Debug.Log("Richtig !");
            canClick = false;

        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && (currentScene.name == "Antworten") && (right == false) && canClick == true)
        {
            Debug.Log("Falsch !");
            canClick = false;
        }
    }
}
