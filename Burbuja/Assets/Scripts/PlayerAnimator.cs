using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    public Animator animator;
    public float runSpeed = 5f;
    private float x, y;

    void Update()
    {
        // Capturar el input horizontal y vertical
        x = Input.GetAxis("Horizontal"); // A/D o Flechas Izq/Der
        y = Input.GetAxis("Vertical");   // W/S o Flechas Arriba/Abajo

        // Movimiento del personaje
        Vector3 movement = new Vector3(x, 0, y) * runSpeed * Time.deltaTime;
        transform.Translate(movement, Space.World);

        // Ajustar rotación según la dirección de movimiento
        if (x != 0 || y != 0)
        {
            Vector3 lookDirection = new Vector3(x, 0, y);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(lookDirection), 0.15f);
        }

        // Actualizar parámetros del Animator
        animator.SetFloat("VelX", x);
        animator.SetFloat("VelY", y);
    }
}