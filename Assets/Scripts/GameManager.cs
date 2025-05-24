using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; //Variable para poder acceder al GameManager desde cualquier script.
    
    public int Monedas = 0; //Variable del contador de monedas.
    public TextMeshProUGUI textoMonedas; //Variable de texto.

    void Awake () //Cargar la moneda, se ejecuta antes del start().
    {
        if (instance == null) //Condición, si todavia no hay un GamManager asignado.
        {
            instance = this; //El obj. se convierte en instancia principal.
        }
    }

    public void SumarMoneda() //Método de sumar monedas
    {
        Monedas++; //Sumar monedas en 1.
        textoMonedas.text = " " + Monedas; //Cambiar texto (numero) al recoger moneda.
    }
}