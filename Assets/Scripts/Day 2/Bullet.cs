using UnityEngine;

public class Bullet : MonoBehaviour
{
    public bool isPlayerBullet = true; 
    public float lifetime = 3f;

    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isPlayerBullet && collision.CompareTag("Enemy"))
        {
            GameManager.instance.AddScore(10);

            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if (!isPlayerBullet && collision.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
