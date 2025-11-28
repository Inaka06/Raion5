using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    

    Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    Vector2 movement;
    void Update()
    {
       movement.x = Input.GetAxisRaw("Horizontal");
       movement.y = Input.GetAxisRaw("Vertical");
       Debug.Log(movement.x+ " | " +movement.y);

       rb.MovePosition(rb.position+movement*5*Time.fixedDeltaTime);
    }
}
