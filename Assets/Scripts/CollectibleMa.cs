using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectibleMa : MonoBehaviour
{
    public int count = 0;
    public int totalAlfajores = 5;
    public TextMeshProUGUI counterText;
    public Timer timer;

    public void AddCollectible()
    {
        count++;
        Debug.Log("Alfajores recolectados: " + count);

        if (counterText != null)
            counterText.text = "Objetos Recolectados: " + count;

        if (count >= totalAlfajores)
        {
            timer.DetenerTimer();
            Debug.Log("¡Completaste la partida!");
        }
    }
}