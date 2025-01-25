using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float runSpeed = 7;
    public float rotationSpeed = 250;
    public Animator animator;
    private float x, y, z;

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis ("Vertical");
        z = Input.GetAxis("Jump");
        transform.Rotate(0, x * Time.deltaTime * rotationSpeed, 0);
        transform.Translate(0,0,y * Time.deltaTime * runSpeed);
        animator.SetFloat("VelX", x);
        animator.SetFloat("VelY", y);
        animator.SetFloat("VelZ", z);
    }
}
