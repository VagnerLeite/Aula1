using UnityEngine;
using System.Collections;
// Clona o gordinho aleatoriamente na tela
public class clonadorScript : MonoBehaviour {
	public GameObject gordinho2; // Armazenará o prefab Gordinho2
	// Variável para conhecer quão rápido nós devemos criar novos Asteroides
    public float spawnTime = (float) 1.5;
	void Start() {
		// Chamar a função 'addEnemy' a cada 'spawnTime' segundos
		InvokeRepeating("addEnemy", spawnTime, spawnTime);
	}
	// Nova função para clonar/spawn um Asteroide
	void addEnemy() {
		// Variável para armazenar a posição Y do objeto spawn. 
		Renderer renderer = GetComponent<Renderer>();
		var y1 = transform.position.y - renderer.bounds.size.y/2;
		var y2 = transform.position.y + renderer.bounds.size.y/2;
		// Aleatoriamente escolhe um ponto dentro do objeto spawn
        var spawnPoint = new Vector2(transform.position.x, Random.Range(y1, y2));
		// Criar um Asteroide na posição 'spawnPoint'
        Instantiate(gordinho2, spawnPoint, Quaternion.identity);
	}
}