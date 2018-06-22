using UnityEngine;
using System.Collections;
public class planetScript : MonoBehaviour
{
    
    private pontosScript ptScript; // Para se comunicar com o juggernautScript
    private vidasScript vidaScript; // Para se comunicar com o juggernaultScript
    private vidaPlanetScript vidaPlanetScript; // Para se comunicar com o juggernaultScript

    public AudioClip audioGrito; // Arrastar o audio da bala // para esta variavel

    // Chamada quando o planet é criado
    void Start()
    {
        ptScript = GameObject.Find("Pontuacao").GetComponent<pontosScript>();
        vidaScript = GameObject.Find("Vidas").GetComponent<vidasScript>();
        vidaPlanetScript = GameObject.Find("vidaPlanet").GetComponent<vidaPlanetScript>();
    }

    void OnTriggerEnter2D(Collider2D outro)
    {
        
        if (outro.gameObject.tag == "balaTag")
        {
            vidaPlanetScript.planet --;
            if (vidaPlanetScript.planet == 0)
            {
                Destroy(this.gameObject);
                AudioSource.PlayClipAtPoint(audioGrito, transform.position);
            }
        }
    }
}