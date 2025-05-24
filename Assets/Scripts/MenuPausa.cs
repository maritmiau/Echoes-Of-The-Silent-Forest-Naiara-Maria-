using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public GameObject menuPausa; // Asignar el objeto del men� en el inspector.
    private bool juegoPausado = false;
    public AudioSource musicaDeFondo; // Referencia al AudioSource de la m�sica.
   


    void Update()
    {
        // Detectar si se presiona la tecla ESC.
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (juegoPausado)
            {
                ContinuarJuego(); // Reanudar si ya est� pausado.
            }
            else
            {
                PausarJuego(); // Pausar si no lo est�.
            }
        }
    }

    public void PausarJuego()
    {
        menuPausa.SetActive(true); // Activar el men� de pausa.
        Time.timeScale = 0f; // Detener el tiempo del juego.
        if (musicaDeFondo != null && musicaDeFondo.isPlaying)
            if (musicaDeFondo != null)
            {
                musicaDeFondo.Pause(); // Pausar la m�sica.
            }
        juegoPausado = true;
    }

    public void ContinuarJuego()
    {
        menuPausa.SetActive(false); // Desactivar el men� de pausa.
        Time.timeScale = 1f; // Reanudar el tiempo del juego.
        if (musicaDeFondo != null)
        {
            if (!musicaDeFondo.isPlaying) // Asegurarnos de que no est� en reproducci�n.
            {
                musicaDeFondo.UnPause(); // Reanudar desde donde se paus�.
            }
        }
            juegoPausado = false;
    }

    public void SalirAlMenu()
    {
        Time.timeScale = 1f; // Asegurarse de reanudar el tiempo.
        SceneManager.LoadScene("MenuInicial"); // Cargar la escena del men� inicial.
    }
}
