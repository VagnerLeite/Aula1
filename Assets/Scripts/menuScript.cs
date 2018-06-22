using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class menuScript : MonoBehaviour {
    

    public bool sound = false;

    public AudioClip audioDMX;

	// Use this for initialization
	void Start () {
        AudioSource.PlayClipAtPoint(audioDMX, transform.position);
	}
	
	// Update is called once per frame
	void Update () {
        //Se apertar Esc vai sair do jogo. no Executavel
        if (Input.GetKey("escape")){
            Application.Quit();
        }
	}

	public void carregarFase1(){
        //
        SceneManager.LoadScene("fase1");
        //Thread.Sleep(3000);
		
	}

	public void sair(){
		Application.Quit();
	}
}
