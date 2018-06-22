using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vidaPlanetScript : MonoBehaviour
{
    public Text planetUI; //arrastar da hierarquia Vidas para a variavel publica
    public int planet = 45; //dar acesso ao script Juggernault, por isso public


    // Update is called once per frame
    void Update()
    {
        planetUI.text = "Planet: " + planet;
    }
}
