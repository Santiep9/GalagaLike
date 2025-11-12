using UnityEngine;

public class Nave : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    public float MovementSpeed = 10.00f;

    public GameObject proyectilPrefab;
    public Transform inicioTrayectoria;
    public float proyectilVel = 10.00f;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();  
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Disparo();
        }
    }

    private void FixedUpdate()
    {
        //valor entre -1 y 1 (Left Right)
        float movement= Input.GetAxis("Horizontal");

        rigidbody2D.linearVelocity= Vector2.right * movement * MovementSpeed;
    }

    void Disparo()
    {
        GameObject proyectil = Instantiate(proyectilPrefab, inicioTrayectoria.transform.position, inicioTrayectoria.transform.rotation);

        Rigidbody2D rb = proyectil.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.linearVelocity = inicioTrayectoria.up * proyectilVel;
        }
    }
}
