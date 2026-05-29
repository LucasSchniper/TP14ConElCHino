using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float tiempoTranscurrido = 0f;
    public bool corriendo = true;
    public TextMeshProUGUI timerText;

    void Update()
    {
        if (!corriendo) return;

        tiempoTranscurrido += Time.deltaTime;

        if (timerText != null)
            timerText.text = FormatearTiempo(tiempoTranscurrido);
    }

    public string FormatearTiempo(float segundos)
    {
        int min = (int)(segundos / 60);
        int seg = (int)(segundos % 60);
        return string.Format("{0:00}:{1:00}", min, seg);
    }

    public void DetenerTimer()
    {
        corriendo = false;
        Debug.Log("Tiempo final: " + FormatearTiempo(tiempoTranscurrido));
    }

    public float ObtenerTiempo()
    {
        return tiempoTranscurrido;
    }
}
