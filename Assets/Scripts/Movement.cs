using UnityEngine;

public class Movement : MonoBehaviour
{
    Vector2 movement;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
        Debug.Log("Movement: " + movement.x + " | " + movement.y);

        rb.MovePosition(rb.position + movement * 1);
        transform.Rotate(0, 0, -movement.x *5);
        //hehe

    }
}
