using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float timer = 60f;
    private UIManager uiManager;

    void Awake()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    void Update()
    {
        if (timer <= 0f) return;

        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            timer = 0f;
            uiManager.UpdateTimer(0f);
            uiManager.MostrarDerrota();
            return;
        }

        uiManager.UpdateTimer(timer);
    }

    public void JugadorGano()
    {
        float tiempoUsado = 60f - timer;
        timer = -1f;
        int seg = (int)(tiempoUsado % 60);
        int min = (int)(tiempoUsado / 60);
        uiManager.MostrarVictoria(string.Format("{0:00}:{1:00}", min, seg));
    }
}
