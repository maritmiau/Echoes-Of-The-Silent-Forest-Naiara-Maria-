using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Naiara Guarín, Nayara Sosa, Maria Tello.
 * Script spawner de obstáculos. 
 * Spawnearan los obstáculos en la pantalla de juego.
 */

public class Spawner : MonoBehaviour
{
    //Crear variables.
    public GameObject[] obstaculos; //Array para los obstáculos.
    public Transform spawnPoint; //Punto donde se generaran los obstáculos.
    public float spawnInterval = 2f; //Tiempo que pasa entre que se genera un obstáculo y otro.
    public float minSpawnDist = 10f; //Distancia mínima entre uno y otro.
    public float maxSpawnDist = 20f; //Distancia máxima entre uno y otro.
    public float gameSpeed = 5f; //Velocidad del juego.
    public int damage = 10; 

    private float timer = 0f; //Temporizador.

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval) //Si el tiempo que pasa > al tiempo establecido se genera un nuevo obstáculo.
        {
            SpawnObstaculo(); //Llamamos al método SpawnObstaculo para que se genere uno nuevo.
            timer = 0f; //Reinicia el temporizador.
        }
    }

    void SpawnObstaculo() //Método para seleccionar un obstáculo del array y generarlo en la posición del punto de spawn.
    {
        GameObject obstaculo = obstaculos [Random.Range(0, obstaculos.Length)]; //Selecciona un obstáculo aleatorio dentro del array.

        Instantiate (obstaculo, spawnPoint.position, Quaternion.identity); //Genera un obstáculo en el punto sin rotación (Quaternion.identity).
    }
}
