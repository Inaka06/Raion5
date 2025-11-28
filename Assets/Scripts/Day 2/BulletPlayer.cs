using UnityEngine;

public class BulletPlayer : MonoBehaviour
{
    public bool isPlayerBullet = true; 
    public float lifetime = 3f;

    public GameObject explosionPrefab;

    void Start()
    {
        Destroy(gameObject, lifetime);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if(other.CompareTag("Enemy") || other.CompareTag("EnemyBullet"))
        {
            Destroy(other.gameObject);
        }

        if (other.CompareTag("Enemy"))
        {
            GameManager.instance.AddScore(10);
        }
        
        if(other.CompareTag("Enemy"))//animasi ledakan
        {
            GameObject explosion = Instantiate(explosionPrefab, other.transform.position, Quaternion.identity);
            Destroy(explosion, 1f);
        }
    }
}
