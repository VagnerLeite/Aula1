using UnityEngine;
using System.Collections;
public class juggernautScript : MonoBehaviour
{


    private pontosScript ptScript; // Para se comunicar com o deadpoolScript
    private vidasScript vidaScript; // Para se comunicar com o juggernaultScript
    private vidaJuScript vidaJuScript; // Para se comunicar com o juggernaultScript

    public AudioClip audioGrito; // Arrastar o audio ddo grito // para esta variavel

    // Chamada quando o juggernault é criado
    void Start()
    {
        ptScript = GameObject.Find("Pontuacao").GetComponent<pontosScript>();
        vidaScript = GameObject.Find("Vidas").GetComponent<vidasScript>();
        vidaJuScript = GameObject.Find("VidaJu").GetComponent<vidaJuScript>();
    }

    void OnTriggerEnter2D(Collider2D outro)
    {

        if (outro.gameObject.tag == "balaTag")
        {
            vidaJuScript.ju --;
            if (vidaJuScript.ju == 0)
            {
                Destroy(this.gameObject); // Quando zera a vida ele grita e morre
                AudioSource.PlayClipAtPoint(audioGrito, transform.position);
            }
        }
    }
}