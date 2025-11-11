using UnityEngine;

public class KnightScript : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    public float MovementSpeed = 10.00f;
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();  
    }

    
    void Update()
    {
        Debug.Log ("Update");
    }

    private void FixedUpdate()
    {
        //valor entre -1 y 1 (Left Right)
        float movement= Input.GetAxis("Horizontal");

 rigidbody2D.linearVelocity= Vector2.right* movement*MovementSpeed ;
        
    }   

}
