using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class gordinhoEScript : MonoBehaviour
{
    // Contem a velocidade do gordinho
    public int speed = +4;
    private pontosScript ptScript; // Para se comunicar
    private vidasScript vidaScript; // Para se comunicar com o juggernaultScript

    public AudioClip audioFuck; // Arrastar o audio do gordinho // para esta variavel

    public Text gameOverUI;
    // Chamada quando o gordinho é criado
    void Start()
    {
        ptScript = GameObject.Find("Pontuacao").GetComponent<pontosScript>();
        vidaScript = GameObject.Find("Vidas").GetComponent<vidasScript>();

        // Adicionar speed à velocidade do gordinho
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed, 0);// O primeiro Parametro é o eixo x, e o segundo o eixo Y;


        // Destroi o gordinho após 3s, que ele não está mais visível na tela
        Destroy(gameObject, 4);
    }

    void OnTriggerEnter2D(Collider2D outro)
    {
        
        if (outro.gameObject.tag == "balaTag")
        {

            Destroy(this.gameObject);
            vidaScript.vidas--;

            if (vidaScript.vidas == 0)
            {
                AudioSource.PlayClipAtPoint(audioFuck, transform.position);
                // Nao funciona essa caralha de som.. acho que é porque ele é destruido..

            }

            if (vidaScript.vidas == 0)
            {
                SceneManager.LoadScene("menu");
                AudioSource.PlayClipAtPoint(audioFuck, transform.position);
                // Nao funciona essa caralha de som.. acho que é porque ele é destruido..

            }
        }
    }
}