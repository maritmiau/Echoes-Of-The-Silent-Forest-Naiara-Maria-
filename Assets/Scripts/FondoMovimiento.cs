using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FondoMovimiento : MonoBehaviour
{
    [SerializeField] private Vector2 velocidadMovimiento; // Velocidad del movimiento del fondo en los ejes X e Y.
    private Vector2 offset; // Variable para almacenar el desplazamiento de la textura.
    private Material material;// Referencia al material del SpriteRenderer.

    private void Awake() // Metodo Awake: Se ejecuta una vez al iniciar el script antes de Start.
    {
        material = GetComponent<SpriteRenderer>().material;// Obtiene el material del SpriteRenderer adjunto a este GameObject.
    }

    private void Update()
    {
        offset = velocidadMovimiento * Time.deltaTime;// Calcula el desplazamiento basado en la velocidad y el tiempo transcurrido.
        material.mainTextureOffset += offset; // Ajusta el desplazamiento de la textura del material (efecto scrolling).
    }
}

