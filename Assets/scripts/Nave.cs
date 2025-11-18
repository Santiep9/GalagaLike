using UnityEngine;

public class Nave : MonoBehaviour
{
    public float MovementSpeed = 10.0f;
    public GameObject proyectilPrefab;
    public Transform[] firePoints;
    public float proyectilVel = 10.0f;

    private Rigidbody2D rigidbody2D;

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

    void FixedUpdate()
    {
        float movement = Input.GetAxis("Horizontal");
        rigidbody2D.velocity = Vector2.right * movement * MovementSpeed;
    }

    void Disparo()
    {
        foreach (Transform firePoint in firePoints)
        {
            if (proyectilPrefab != null && firePoint != null)
            {
                GameObject proyectil = Instantiate(proyectilPrefab, firePoint.position, Quaternion.identity);
                Rigidbody2D rb = proyectil.GetComponent<Rigidbody2D>();
                if (rb != null)
                    rb.velocity = Vector2.up * proyectilVel;
            }
        }
    }
}