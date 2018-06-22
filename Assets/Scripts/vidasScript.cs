using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vidasScript : MonoBehaviour
{
    public Text vidasUI; //arrastar da hierarquia Vidas para a variavel publica
                          //pontos da main camera
    public int vidas = 5; //dar acesso ao script Juggernault, por isso public


    // Update is called once per frame
    void Update()
    {
        vidasUI.text = "Vidas: " + vidas;
    }
}
