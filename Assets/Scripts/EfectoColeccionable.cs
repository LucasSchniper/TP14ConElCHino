using UnityEngine;

public class EfectoColeccionable : MonoBehaviour
{
    public float velocidadGiro = 90f;
    public float alturaRebote = 0.3f;
    public float velocidadRebote = 2f;

    private Vector3 posicionBase;

    void Start()
    {
        posicionBase = transform.position;
    }

    void Update()
    {
        transform.Rotate(0f, velocidadGiro * Time.deltaTime, 0f, Space.World);
        float y = posicionBase.y + Mathf.Sin(Time.time * velocidadRebote) * alturaRebote;
        transform.position = new Vector3(posicionBase.x, y, posicionBase.z);
    }
}