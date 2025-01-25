using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 5f;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal*speed, rb.linearVelocity.y, moveVertical*speed);
        rb.linearVelocity = movement;
    }

    
}
