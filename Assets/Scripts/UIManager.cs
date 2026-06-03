using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;
    public GameObject panelVictoria;
    public TextMeshProUGUI mensajeVictoria;

    public GameObject panelDerrota;
    public TextMeshProUGUI mensajeDerrota;

    private bool juegoTerminado = false;

    public void UpdateScore(int score)
    {
        if (scoreText != null)
            scoreText.text = "Objetos: " + score;
    }

    public void UpdateTimer(float tiempo)
    {
        if (timerText != null)
            timerText.text = FormatearTiempo(tiempo);
    }

    public void MostrarVictoria(string tiempo)
    {
        juegoTerminado = true;
        OcultarHUD();
        if (panelVictoria != null) panelVictoria.SetActive(true);
        if (mensajeVictoria != null)
            mensajeVictoria.text = "¡Ganaste! Tardaste: " + tiempo + "\nTocá R para reiniciar";
    }

    public void MostrarDerrota()
    {
        juegoTerminado = true;
        OcultarHUD();
        if (panelDerrota != null) panelDerrota.SetActive(true);
        if (mensajeDerrota != null)
            mensajeDerrota.text = "¡Perdiste! Se acabó el tiempo.\nTocá R para reiniciar";
    }

    void Update()
    {
        if (juegoTerminado && Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void OcultarHUD()
    {
        if (scoreText != null) scoreText.gameObject.SetActive(false);
        if (timerText != null) timerText.gameObject.SetActive(false);
    }

    private string FormatearTiempo(float segundos)
    {
        int min = (int)(segundos / 60);
        int seg = (int)(segundos % 60);
        return string.Format("{0:00}:{1:00}", min, seg);
    }
}
    