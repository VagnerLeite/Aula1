using UnityEngine;
using System.Collections;
public class explosaoScript : MonoBehaviour
{

    // Uso esse script so pra destruir a explosao depois do contato, nao consegui de outra forma
    void Start()
    {
      
    }

    // Quando a bala ficar invisível será destruída
    void OnBecameInvisible()
    {// Destroi a bala quando já está fora da tela
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D outro)
    {
        Destroy(this.gameObject);
    }

}