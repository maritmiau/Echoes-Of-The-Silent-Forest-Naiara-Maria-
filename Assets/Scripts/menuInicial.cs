using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuInicial : MonoBehaviour
{
    // Metodo publico que se llama cuando el jugador selecciona la opcion de "Jugar".
    public void Jugar ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Obtiene el indice de la escena actual y carga la siguiente escena (indice actual + 1).
    }

    public void Salir()  // Metodo publico que se llama cuando el jugador selecciona la opcion de "Salir".
    {
        Debug.Log("Salir");
        Application.Quit();   // Cierra la aplicacion.
    }
}