using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HauptMenü : MonoBehaviour {

    public static int[] intArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    int i = 0;
    // Use this for initialization
    void Start () {
        for (int i = 9; i > 0; i--)
        {

            int j = Random.Range(0, 9);
            int temp = intArray[i];
            intArray[i] = intArray[j];
            intArray[j] = temp;
        }

        for (int i = 0; i < 10; i++)
        {
            Debug.Log("IntArray " + intArray[i]);

        }
        
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
