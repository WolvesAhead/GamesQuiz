using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fragen : MonoBehaviour {

    public Text txt;
    string[] FragenArray = { "Frage 1", "Frage 2", "Frage 3", "Frage 4", "Frage 5", "Frage 6", "Frage 7", "Frage 8", "Frage 9", "Frage 10" };
    public static int Fragennum = 0;
    // Use this for initialization
    void Start () {
              
		
	}
	
	// Update is called once per frame
	void Update () {
        txt.text = FragenArray[Fragennum];

	}
}
