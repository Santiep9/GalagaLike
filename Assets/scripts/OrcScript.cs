using UnityEngine;

public class OrcScript : MonoBehaviour

{
    private Rigidbody2D rigidbody2D;
    public float MovementSpeed = 0.5f;
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();

        transform.position = new Vector2(Random.Range(-3.0f,3.0f), 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        rigidbody2D.AddForce(Vector2.down*MovementSpeed );
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}

