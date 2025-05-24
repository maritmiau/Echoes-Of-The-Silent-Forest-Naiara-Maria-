using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Naiara Guarín, Nayara Sosa, Maria Tello.
 * Script del tronco.
 * Movimiento del tronco.
 * Si el tronco le da al player se le resta 1 punto de vida.
 * Si el tronco le da al player se destuye.
 */

public class MovTronco : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (rb != null) //Comprueba si el obj tiene Rigidbody2D.
        {
            rb.velocity = new Vector2(-5f, 0); //Hace que el obstáculo se desplace hacia la izquierda.
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Creamos condición para que si el cuervo toca al Player (su tag):
        if (collision.tag == "Player") 
        {
            var healthComponent = collision.GetComponent<MovimentPlayer>();
            if (healthComponent != null) //Si el componente MovimentPlayer fue encontrado en el objeto de colisión.
            {
                healthComponent.TakeDamage(1); //1. Llama al método TakeDamage (del script del Player) y le quita 1 punto de vida.
                Debug.Log("Se le ha restado vida"); //2. Lo escribe en la consola.
                Destroy(gameObject); //3. Se destruye el cuervo.
            }
        }
    }
}
