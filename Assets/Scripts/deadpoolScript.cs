using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class deadpoolScript : MonoBehaviour
{
    public GameObject bala; // A ser preenchido via Inspector com o prefab bala
    public int speed = 10;
    public Text gameOverUI;

    public AudioClip audioBalaColisao; // Arrastar o audio da bala // para esta variavel
    public AudioClip audioTouching;

    // Use this for initialization
    void Start()
    {
        AudioSource.PlayClipAtPoint(audioTouching, transform.position); // Audio de entrada
    }

    void Update()
    {
        // Move a nave horizontalmente com setas ou com as teclas A e D
        // Eixo X – na horizontal
        float horizontal = Input.GetAxis("Horizontal") * speed *
            Time.deltaTime;
        transform.Translate(horizontal, 0, 0);// Aplicando as mudanças

        /*float vertical = Input.GetAxis("Vertical") * speed *
            Time.deltaTime;
        transform.Translate(0, vertical, 0);// Aplicando as mudanças

        transform.Translate(horizontal, 0, 0);// Aplicando as mudanças*/

        //Restringir o movimento entre dois valores
        if (transform.position.x <= -5.6f || transform.position.x >= 5.6f)
        {
            // Criando o limite
            float xPos = Mathf.Clamp(transform.position.x, -5.6f, 5.6f);
            // Limitando
            transform.position = new Vector3(xPos, transform.position.y,
                transform.position.z);
        }

        //Restringir o movimento entre dois valores
        if (transform.position.y <= -4.5f || transform.position.y >= 4.5f)
        {
            // Criando o limite
            float yPos = Mathf.Clamp(transform.position.y, -4.5f, 4.5f);
            // Limitando
            transform.position = new Vector3(transform.position.x, yPos,
                transform.position.z);
        }

        // Quando a barra de espaços é pressionada ele atira
        if (Input.GetKeyDown("space"))
        {
            // Cria uma nova bala na posiçao atual do Deadpool para que siga a nave
            Instantiate(bala, transform.position, Quaternion.identity);
        }

        //Atualizando na tela o campo vidas com o valor atual de vidas do Deadpool
        //vidasUI.text = "Vidas: " + vidas;
    }

    void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.gameObject.tag == "gordinhoTag")
        {
            AudioSource.PlayClipAtPoint(audioBalaColisao, transform.position);
            /*vidas = vidas - 1; // Cada colisao perde uma vida
            if (vidas == 0)
            {// Quando topar 3 vezes com o inimigo, o Deadpool morre
                vidasUI.text = "Vidas: " + vidas;
                Destroy(this.gameObject);

                gameOverUI.text = "GAME OVER";
                SceneManager.LoadScene("menu");
            }*/
        }
    }
}