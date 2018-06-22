using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pontosScript : MonoBehaviour {
	public Text pontosUI; //arrastar da hierarquia Pontos para a variavel publica
	//pontos da main camera
	public int pontos = 0; //dar acesso ao script nave, por isso public	
	
	// Update is called once per frame
	void Update () {
		pontosUI.text = "Pontuacao: " + pontos;
	}
}
