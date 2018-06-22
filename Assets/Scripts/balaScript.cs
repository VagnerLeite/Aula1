using UnityEngine;
using System.Collections;
public class balaScript : MonoBehaviour {
    public GameObject explosao; // A ser preenchido via Inspector com o prefab explosao

	public float speed = 15; 
	private pontosScript refPontosScript;

    public AudioClip audioFuck; // Arrastar o audio do gordinho // para esta variavel


	// É chamado apenas uma vez quando a bala é criada
	void Start () {
		// Ajusta a velocidade Y para fazer a bala se mover para cima
		Rigidbody2D rb = GetComponent<Rigidbody2D> ();
		rb.velocity = new Vector2(0, speed);

		refPontosScript = GameObject.Find ("Pontuacao").GetComponent<pontosScript> ();
	}

	// Quando a bala ficar invisível será destruída
	void OnBecameInvisible() {
		// Destroi a bala quando já está fora da tela
		Destroy(gameObject);
	}

	void OnTriggerEnter2D (Collider2D outro){
        // Aqui sao as acoes quando a bala atinge o gordinho
        // Ele morre, depois eu instancio a explosao, e ele grita
		if(outro.gameObject.tag == "gordinhoTag"){
            Destroy(this.gameObject);
            Instantiate(explosao, transform.position, Quaternion.identity);
            AudioSource.PlayClipAtPoint(audioFuck, transform.position);
		}

        // Quando atinge o planeta soma os pontos e destroi a bala
        // e assim com os outros tambem
        if (outro.gameObject.tag == "planetTag")
        {
            refPontosScript.pontos += 30;
            Destroy(this.gameObject);
            Instantiate(explosao, transform.position, Quaternion.identity);
        }

        if (outro.gameObject.tag == "juggernaultTag")
        {
            refPontosScript.pontos += 10;
            Destroy(this.gameObject);
            Instantiate(explosao, transform.position, Quaternion.identity);
        }

        if (outro.gameObject.tag == "cableTag")
        {
            refPontosScript.pontos += 20;
            Destroy(this.gameObject);
            Instantiate(explosao, transform.position, Quaternion.identity);
        }
	}
}