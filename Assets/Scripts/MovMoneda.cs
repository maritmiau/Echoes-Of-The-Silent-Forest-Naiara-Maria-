using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Naiara Guarín, Nayara Sosa, Maria Tello.
 * Script de las monedas.
 * Movimiento de la moneda.
 * Si el player toca la moneda se destruye.
 */

public class MovMoneda : MonoBehaviour
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

    void OnTriggerEnter2D(Collider2D collision) //Usamos este void para hacer que cuando el player toque la moneda se destruya.
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

}