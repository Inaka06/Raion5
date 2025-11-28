using UnityEngine;

public class BulletPlayer : MonoBehaviour
{

    AudioManager audioManager;

    public bool isPlayerBullet = true; 
    public float lifetime = 3f;

    public GameObject explosionPrefab;

    void Start()
    {
        Destroy(gameObject, lifetime);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        
        if(other.CompareTag("Enemy"))//animasi ledakan
        {
            GameManager.instance.AddScore(10);
            AudioManager.Instance.PlaySFX(AudioManager.Instance.boomSFXClip);
            GameObject explosion = Instantiate(explosionPrefab, other.transform.position, Quaternion.identity);
            Destroy(explosion, 1f);
        }

        if(other.CompareTag("Enemy") || other.CompareTag("EnemyBullet"))
        {
            Destroy(other.gameObject);
        }
    }
}
