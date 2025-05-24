using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*
 * Naiara Guarin, Nayara Sosa, Maria Tello.
 * Script del player. 
 * Salto programado + animacion del salto.
 * Sistema de vida.
 * Reinicio del juego.
 */

public class MovimentPlayer : MonoBehaviour
{
    //Declaramos las variables para que el Player salte.
    public float FuerzaSalto; //Variable de la fuerza del salto.
    public bool enSuelo; //Para comprobar que el player toca el suelo.
    public Rigidbody2D myRigidbody; 
    public Transform TocaElSuelo; //Obj. que verifica que el Player esta tocando el suelo.
    public LayerMask Suelo; //Capa del suelo para verificar colisiones.
    public AudioClip sonidoSalto;
    private AudioSource audioSource;
    //So del salt
    public AudioClip sonidoDaño; // Efecto de sonido al recibir daño

    //Declaramos variables de animaciones.
    Animator myAnimation; //Animacion 1 (salto).
    Animator myAnimation2; //Animacion 2 (agacharse).

    //Declaramos variables para el sistema de vida del Player.
    public int vidaMax = 3; 
    public int vidaActual;

    public GameObject gameOverUI; //Variable para el canvas GameOver.

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>(); //Asignamos el rigidbody del Player.
        myAnimation = GetComponent<Animator>(); //Detectar animator.
        myAnimation2 = GetComponent<Animator>(); //*
        vidaActual = vidaMax; //La vida del Player al principio del juego = vida m�xima.
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        enSuelo = Physics2D.OverlapCircle(TocaElSuelo.position, 0.2f, Suelo); //Verifica si el pj esta tocando el suelo.

        //Creamos condicion para que si esta tocando el suelo el Player pueda saltar.
        if (enSuelo && Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.velocity = new Vector2 (myRigidbody.velocity.x, FuerzaSalto); //Aplicamos velocidad para que el Player salte.
            myAnimation.SetTrigger("Salto");

            audioSource.PlayOneShot(sonidoSalto); //es reprodueix el so
            if (sonidoSalto != null)
            {
                audioSource.PlayOneShot(sonidoSalto); //reproducimos el sonido
            }

            //Si dona error es posa automaticament
          
        }
    }

    void OnAgacharse() //Metodo para que el Player se agache.
    {
            myAnimation2.SetTrigger("Agachado");
    }

    public void TakeDamage(int damage) //Metodo para recibir da�o.
    {
        vidaActual -= damage;

        // Reproduce el sonido de daño si está configurado
        if (sonidoDaño != null)
        {
            audioSource.PlayOneShot(sonidoDaño); //llamamos al sonido

        }

        // Comprueba si la vida llego a 0
        if (vidaActual <= 0)
        {
            GameOver(); // Llamamos al metodo para finalizar el juego
        }
    }

    void GameOver() //Metodo para que se finalice el juego.
    {
        Debug.Log("Has muerto...");
        Time.timeScale = 0; //Detiene el tiempo del juego, se para.
        gameOverUI.SetActive(true); //Muestra la interfaz Game Over (el canvas GameOver).
    }

    public void ReiniciarJuego() //Metodo para reiniciar el juego.
    {
        Time.timeScale = 1; //Reanudamos el tiempo del juego, se reproduce.
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //Recarga la escena del juego.
    }
}


     
