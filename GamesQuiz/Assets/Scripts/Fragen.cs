using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fragen : MonoBehaviour {

    public Text txt;
    public Text txt2;




    string[] FragenArray = { "Aus wie vielen CDs bestand Final Fantasy VII in der PC-Version?", "Wie oft wird das Wort Fuck in GTA:San Andreas gesagt?", "Wie lautet Super Marios ursprünglicher Name?", "Welche Spielkonsole wurde weltweit am meisten verkauft?", "Was wurde nach dem blauen Igel Sonic benannt?", "Wie viele verschiedene Enden hat Nier: Automata?", "Wie heißt das Pferd des Helden in Shadow of the Colossus?", "Wie heißen Dantes Revolver aus Devil May Cry?", "Welches ist das meistverkaufte Spiel weltweit?", "Wie viele Pokémon gibt es ?" };
    public static int Fragennum = 0;
    // Use this for initialization
    void Start () {
              
		
	}


    // Update is called once per frame
    void Update () {
        txt.text = FragenArray[Fragennum];
        txt2.text = FragenArray[Fragennum];


       


    }
}
