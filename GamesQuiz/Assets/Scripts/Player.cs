﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {
    public static int j = 0 ;
    public static int left = 0;
    public static int up = 1;
    public static int right = 2;
  

    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        Scene currentScene = SceneManager.GetActiveScene();
        

        if (Input.GetKey(KeyCode.UpArrow)&&(currentScene.name == "Fragen"))

        {
          
            SceneManager.LoadScene("Antworten");
          

        }
        if (Input.GetKey(KeyCode.Space) && (currentScene.name == "Antworten"))
        {
            Fragen.Fragennum++;
            SceneManager.LoadScene("Fragen");
        }

       


    }
}
