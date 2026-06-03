using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float timer = 60f;
    private float tiempoInicial;
    private UIManager uiManager;

    void Awake()
    {
        tiempoInicial = timer;
    }

    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
        uiManager.UpdateTimer(timer);
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
        float tiempoUsado = tiempoInicial - timer;
        timer = -1f;
        int seg = (int)(tiempoUsado % 60);
        int min = (int)(tiempoUsado / 60);
        uiManager.MostrarVictoria(string.Format("{0:00}:{1:00}", min, seg));
    }
}
