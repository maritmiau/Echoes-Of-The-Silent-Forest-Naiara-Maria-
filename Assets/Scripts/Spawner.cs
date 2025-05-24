using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Naiara Guar�n, Nayara Sosa, Maria Tello.
 * Script spawner de obst�culos. 
 * Spawnearan los obst�culos en la pantalla de juego.
 */

public class Spawner : MonoBehaviour
{
    //Crear variables.
    public GameObject[] obstaculos; //Array para los obst�culos.
    public Transform spawnPoint; //Punto donde se generaran los obst�culos.
    public float spawnInterval = 2f; //Tiempo que pasa entre que se genera un obst�culo y otro.
    public float minSpawnDist = 10f; //Distancia m�nima entre uno y otro.
    public float maxSpawnDist = 20f; //Distancia m�xima entre uno y otro.
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

        if (timer >= spawnInterval) //Si el tiempo que pasa > al tiempo establecido se genera un nuevo obst�culo.
        {
            SpawnObstaculo(); //Llamamos al m�todo SpawnObstaculo para que se genere uno nuevo.
            timer = 0f; //Reinicia el temporizador.
        }
    }

    void SpawnObstaculo() //M�todo para seleccionar un obst�culo del array y generarlo en la posici�n del punto de spawn.
    {
        GameObject obstaculo = obstaculos [Random.Range(0, obstaculos.Length)]; //Selecciona un obst�culo aleatorio dentro del array.

        Instantiate (obstaculo, spawnPoint.position, Quaternion.identity); //Genera un obst�culo en el punto sin rotaci�n (Quaternion.identity).
    }
}
