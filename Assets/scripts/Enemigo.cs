using UnityEngine;
using TMPro;

public class Enemigo : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    public float MovementSpeed = 0.5f;
    public TMP_Text gameOver;
    public TMP_Text contador;
    private int puntos = 0;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();

        transform.position = new Vector2(Random.Range(-3.0f,3.0f), 5f);

        gameOver.text = "";
        contador.text = "Puntos: " + puntos;
    }

    private void FixedUpdate()
    {
        rigidbody2D.AddForce(Vector2.down*MovementSpeed );
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Suelo")
        {
            Destroy(gameObject);
            gameOver.text = "Game Over";
        }

        if (collision.gameObject.tag == "Proyectil")
        {
            puntos++;
            contador.text = "Puntos: " + puntos;
            transform.position = new Vector2(Random.Range(-3.0f, 3.0f), 5f);
            rigidbody2D.linearVelocity = Vector2.zero;
            rigidbody2D.angularVelocity = 0f; 
        }
    }
}

