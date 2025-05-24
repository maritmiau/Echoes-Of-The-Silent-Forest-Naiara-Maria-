using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class MenuOpciones : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private AudioMixer audioMixer; //Variable del AudioMixer.

   public void PantallaCompleta(bool pantantallaCompleta) //M�todo para poner la pantalla completa.
    {
        Screen.fullScreen = pantantallaCompleta;
    }
    public void CambiarVolumen(float volumen) //M�todo para cambiar el volumen de la m�sica.
    {
        audioMixer.SetFloat("Volumen", volumen); //Link al slider.
    }
}
