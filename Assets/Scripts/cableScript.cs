using UnityEngine;
using System.Collections;
public class cableScript : MonoBehaviour
{

    private pontosScript ptScript; // Para se comunicar com o juggernautScript
    private vidasScript vidaScript; // Para se comunicar com o juggernaultScript
    private vidaCableScript vidaCableScript; // Para se comunicar com o juggernaultScript

    public AudioClip audioGrito; // Audio do Grito de morte

    // Chamada quando o planet é criado
    void Start()
    {
        ptScript = GameObject.Find("Pontuacao").GetComponent<pontosScript>();
        vidaScript = GameObject.Find("Vidas").GetComponent<vidasScript>();
        vidaCableScript = GameObject.Find("vidaCable").GetComponent<vidaCableScript>();
    }

    void OnTriggerEnter2D(Collider2D outro)
    {

        if (outro.gameObject.tag == "balaTag")
        {
            
            vidaCableScript.cable--;
            if (vidaCableScript.cable == 0)
            {
                Destroy(this.gameObject);//Mata o personagem e da o grito
                AudioSource.PlayClipAtPoint(audioGrito, transform.position);
            }
        }
    }
}