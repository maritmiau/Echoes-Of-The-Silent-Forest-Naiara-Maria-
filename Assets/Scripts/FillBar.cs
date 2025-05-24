using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Naiara Guarín, Nayara Sosa, Maria Tello.
 * Script de la barra de vida.
 * Se rellenará la barra dependiendo en la vida que tenga el Player.
 */

public class FillBar : MonoBehaviour
{
    //Declarar variables.
    public MovimentPlayer vida; //Referenciamos el script Vida del Player.
    public Image fillImage; //Variable para la barra rellenable.
    private Slider slide; //Variable del slider. 

    // Start is called before the first frame update
    void Awake() //Método que se ejecuta al inicio antes de que comience el juego.
    {
        slide = GetComponent<Slider>(); 
    }

    // Update is called once per frame
    void Update()
    {
        float fillValue = (float)vida.vidaActual / vida.vidaMax; //Calcula el valor de la barra dividiendo la vida actual entre la vida máxima.
        slide.value = fillValue; //Asigna el valor calculado al slider para actualizar la barra de vida.
    }
}
