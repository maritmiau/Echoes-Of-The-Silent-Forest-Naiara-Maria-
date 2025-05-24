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
    // Referencia p�blica al componente VideoPlayer que se asigna desde el editor de Unity.
    public VideoPlayer videoPlayer;

    // Nombre de la escena a la que se cambiar� una vez finalice el video.
    public string nextSceneName = "Jugador";

    // M�todo Start se ejecuta autom�ticamente al iniciar la escena.
    void Start()
    {
        // Se suscribe al evento loopPointReached, que se lanza cuando el video termina.
        // Cuando termina, llama al m�todo EndReached.
        videoPlayer.loopPointReached += EndReached;

        // Inicia la reproducci�n del video.
        videoPlayer.Play();
    }

    // M�todo que se ejecuta cuando el video termina.
    void EndReached(VideoPlayer vp)
    {
        // Cambia de escena al nombre especificado en nextSceneName.
        SceneManager.LoadScene(nextSceneName);
    }

  
    void Update()
    {

    }
}
