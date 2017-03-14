using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fragen : MonoBehaviour {

    public Text txt;
    public Text txt2;
    public static int[] intArray = {0,1,2,3,4,5,6,7,8,9};
    int i = 0;
    bool schongefragt = false; 




    string[] FragenArray = { "Aus wie vielen CDs bestand Final Fantasy VII in der PC-Version?", "Wie oft wird das Wort Fuck in GTA:San Andreas gesagt?", "Wie lautet Super Marios ursprünglicher Name?", "Welche Spielkonsole wurde weltweit am meisten verkauft?", "Was wurde nach dem blauen Igel Sonic benannt?", "Wie viele verschiedene Enden hat Nier: Automata?", "Wie heißt das Pferd des Helden in Shadow of the Colossus?", "Wie heißen Dantes Revolver aus Devil May Cry?", "Welches ist das meistverkaufte Spiel weltweit?", "Wie viele Pokémon gibt es ?" };
    public static int Fragennum;
    public static int counter = 0;

    // Use this for initialization
    void Start () {

      

    }

    void Awake()
    {
        Fragennum = Random.Range(0, 9);

        do
        {
            schongefragt = true;
            Fragennum = Random.Range(0, 9);

            if (intArray[Fragennum] != -1)
            {
                
                schongefragt = false;
            }
        }
        while (schongefragt);


        for (i = 0; i < 10; i++)
        {
            Debug.Log("IntArray " + intArray[i]);
            if (intArray[i] == Fragennum)
            {
                intArray[i] = -1;
              

            }
        }

        
    }


    // Update is called once per frame
    void Update () {
      


        txt.text = FragenArray[Fragennum];
        txt2.text = FragenArray[Fragennum];

    }
}
