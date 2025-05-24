using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public GameObject menuPausa; // Asignar el objeto del menú en el inspector.
    private bool juegoPausado = false;
    public AudioSource musicaDeFondo; // Referencia al AudioSource de la música.
   


    void Update()
    {
        // Detectar si se presiona la tecla ESC.
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (juegoPausado)
            {
                ContinuarJuego(); // Reanudar si ya está pausado.
            }
            else
            {
                PausarJuego(); // Pausar si no lo está.
            }
        }
    }

    public void PausarJuego()
    {
        menuPausa.SetActive(true); // Activar el menú de pausa.
        Time.timeScale = 0f; // Detener el tiempo del juego.
        if (musicaDeFondo != null && musicaDeFondo.isPlaying)
            if (musicaDeFondo != null)
            {
                musicaDeFondo.Pause(); // Pausar la música.
            }
        juegoPausado = true;
    }

    public void ContinuarJuego()
    {
        menuPausa.SetActive(false); // Desactivar el menú de pausa.
        Time.timeScale = 1f; // Reanudar el tiempo del juego.
        if (musicaDeFondo != null)
        {
            if (!musicaDeFondo.isPlaying) // Asegurarnos de que no está en reproducción.
            {
                musicaDeFondo.UnPause(); // Reanudar desde donde se pausó.
            }
        }
            juegoPausado = false;
    }

    public void SalirAlMenu()
    {
        Time.timeScale = 1f; // Asegurarse de reanudar el tiempo.
        SceneManager.LoadScene("MenuInicial"); // Cargar la escena del menú inicial.
    }
}
