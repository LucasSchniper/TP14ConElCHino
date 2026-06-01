using UnityEngine;

public class ObjetosPickup : MonoBehaviour
{
    public int totalColectables = 5;
    private int score = 0;
    private UIManager uiManager;
    private GameManager gameManager;

    void Awake()
    {
        uiManager = FindObjectOfType<UIManager>();
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Collectible")) return;

        score++;
        uiManager.UpdateScore(score);
        Destroy(other.gameObject);

        if (score >= totalColectables)
            gameManager.JugadorGano();
    }
}
