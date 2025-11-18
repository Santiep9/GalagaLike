using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public float velocidad = 1f;

    void Update()
    {
        transform.Translate(Vector2.down * velocidad * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Proyectil"))
        {
            GameManager gm = FindObjectOfType<GameManager>();
            if (gm != null)
            {
                gm.SumarPunto();
                gm.OrcoMuerto();
            }
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        if (other.CompareTag("Suelo"))
        {
            GameManager gm = FindObjectOfType<GameManager>();
            if (gm != null) gm.OrcoMuerto();
            Destroy(gameObject);
        }
        if (other.CompareTag("Player"))
        {
            GameManager gm = FindObjectOfType<GameManager>();
            if (gm != null)
                gm.GameOver();
        }
    }
}