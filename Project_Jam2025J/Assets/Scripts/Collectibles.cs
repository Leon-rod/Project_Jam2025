using UnityEngine;

public class Collectibles : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            FindAnyObjectByType<GameManager>().AddCollectible();
            Destroy(gameObject);
        }
    }
}
