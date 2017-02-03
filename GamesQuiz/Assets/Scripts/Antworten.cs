using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Antworten : MonoBehaviour {

    public Text txt1;
    public Text txt2;
    public Text txt3;
    public static int Fragennum = 0;
   


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


     public static string[] LösungenArray =

    {
      // Lösungen ;
    };


    // Use this for initialization
    void Awake () {
        Debug.Log("J: " + Player.j);
        int i = Player.j;  // counter
            txt1.text = AntwortenArray[i];
            txt2.text = AntwortenArray[i+1];
            txt3.text = AntwortenArray[i+2];
            Player.j += 3;
            Player.left += 3;
            Player.up += 3;
            Player.right += 3;
    }
  

    // Update is called once per frame
    void Update () {
		
	}
}
