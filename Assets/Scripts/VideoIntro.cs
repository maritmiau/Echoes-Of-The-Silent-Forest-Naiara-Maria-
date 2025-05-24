using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
/*
 * Naiara Guarin, Nayara Sosa, Maria Tello.
 * Script del video.
 * Animacion.
 * Cuando le damos al play reproduce la animacion.
 */

public class VideoIntro : MonoBehaviour
{
    // Referencia pública al componente VideoPlayer que se asigna desde el editor de Unity.
    public VideoPlayer videoPlayer;

    // Nombre de la escena a la que se cambiará una vez finalice el video.
    public string nextSceneName = "Jugador";

    // Método Start se ejecuta automáticamente al iniciar la escena.
    void Start()
    {
        // Se suscribe al evento loopPointReached, que se lanza cuando el video termina.
        // Cuando termina, llama al método EndReached.
        videoPlayer.loopPointReached += EndReached;

        // Inicia la reproducción del video.
        videoPlayer.Play();
    }

    // Método que se ejecuta cuando el video termina.
    void EndReached(VideoPlayer vp)
    {
        // Cambia de escena al nombre especificado en nextSceneName.
        SceneManager.LoadScene(nextSceneName);
    }

  
    void Update()
    {

    }
}
