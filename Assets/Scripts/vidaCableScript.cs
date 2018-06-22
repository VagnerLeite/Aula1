using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vidaCableScript : MonoBehaviour
{
    public Text cableUI; //arrastar da hierarquia Vidas para a variavel publica
    public int cable = 40; //dar acesso ao script Juggernault, por isso public


    // Update is called once per frame
    void Update()
    {
        cableUI.text = "Cable: " + cable;
    }
}
