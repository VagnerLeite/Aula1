using UnityEngine;
using System.Collections;
// Clona o gordinho aleatoriamente na tela
public class clonadorEsqScript : MonoBehaviour
{
    public GameObject gordinho; // Armazenará o prefab Gordinho
                                 // Variável para conhecer quão rápido nós devemos criar novos Gordinhos
    public float spawnTime = (float)1.5;
    void Start()
    {
        // Chamar a função 'addEnemy' a cada 'spawnTime' segundos
        InvokeRepeating("addEnemyEsq", spawnTime, spawnTime);
    }
    // Nova função para clonar/spawn um Gordinho
    void addEnemyEsq()
    {
        // Variável para armazenar a posição Y do objeto spawn. 
        Renderer renderer = GetComponent<Renderer>();
        var y1 = transform.position.y - renderer.bounds.size.y / 2;
        var y2 = transform.position.y + renderer.bounds.size.y / 2;
        // Aleatoriamente escolhe um ponto dentro do objeto spawn
        var spawnPoint = new Vector2(transform.position.x, Random.Range(y1, y2));
        // Criar um Gordinho na posição 'spawnPoint'
        Instantiate(gordinho, spawnPoint, Quaternion.identity);
    }
}