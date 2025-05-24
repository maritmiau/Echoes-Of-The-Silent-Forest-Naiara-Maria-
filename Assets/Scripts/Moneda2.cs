using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Naiara Guarin, Nayara Sosa, Maria Tello.
 * Script de las monedas.
 * Movimiento de la moneda.
 * Si el player toca la moneda se destruye.
 */

public class Moneda2 : MonoBehaviour
{
    private Rigidbody2D rb;
    private AudioSource audioSource;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();

        if (rb != null)
        {
            // Configurar velocidad inicial del Rigidbody2D
            rb.velocity = new Vector2(-5f, 0);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (audioSource != null)
            {
                // Reproducir sonido de recolección
                audioSource.Play();
            }

            // Incrementar el contador de monedas (asegúrate de tener un GameManager con esta función)
            GameManager.instance.SumarMoneda();

            // Desactivar SpriteRenderer si existe
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
            if (spriteRenderer != null)
            {
                spriteRenderer.enabled = false;
            }

            // Desactivar Collider para evitar múltiples colisiones
            Collider2D collider = GetComponent<Collider2D>();
            if (collider != null)
            {
                collider.enabled = false;
            }

            // Esperar a que el sonido termine antes de destruir
            if (audioSource != null && audioSource.clip != null)
            {
                Destroy(gameObject, audioSource.clip.length);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
