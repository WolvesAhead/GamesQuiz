using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HauptMenü : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if ((Input.GetKeyDown(KeyCode.LeftArrow)) || (Input.GetKeyDown(KeyCode.UpArrow)) || (Input.GetKeyDown(KeyCode.RightArrow)) || (Input.GetKeyDown(KeyCode.A)) || (Input.GetKeyDown(KeyCode.W)) || (Input.GetKeyDown(KeyCode.D)))

        {
            Fragen.Fragennum = 0;
            Player.j = 0;
            SceneManager.LoadScene("Fragen");
          
           
        }
       
       
    }
}
