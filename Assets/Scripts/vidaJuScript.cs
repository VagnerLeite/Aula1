using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vidaJuScript : MonoBehaviour
{
    public Text juUI; //arrastar da hierarquia Vidas para a variavel publica
    public int ju = 80; //dar acesso ao script Juggernault, por isso public


    // Update is called once per frame
    void Update()
    {
        juUI.text = "Ju: " + ju;
    }
}
