using UnityEngine;

public class Camara : MonoBehaviour
{
    // Aspecto objetivo (por ejemplo, 16:9)
    public float targetAspect = 16f / 9f;

    // Tamaño ortográfico cuando se ve bien en el aspecto objetivo
    public float orthoSizeAtTargetAspect = 5f;

    void Start()
    {
        AjustarCamara();
    }

    void AjustarCamara() //Crear metodo para ajustar el video.
    {
        float currentAspect = (float)Screen.width / (float)Screen.height;
        float scaleFactor = targetAspect / currentAspect;

        Camera.main.orthographicSize = orthoSizeAtTargetAspect * scaleFactor;
    }
}