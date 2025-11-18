using UnityEngine;

public class Proyectil : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 3f); // Autodestruye si no colisiona antes
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Si toca el "Limite", destruye el proyectil que si no hace instakill a los bichos
        if (other.CompareTag("Limite"))
        {
            Destroy(gameObject);
        }

    }
}