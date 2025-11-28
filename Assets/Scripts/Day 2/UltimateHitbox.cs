using UnityEngine;
using System.Collections;

public class UltimateHitbox : MonoBehaviour
{
    AudioManager audioManager;
    public float lifeTime = 0.3f;
    public GameObject explosionPrefab;

    void Start()
    {
        StartCoroutine(ActivateHitbox());
        Destroy(gameObject, lifeTime);
    }

    IEnumerator ActivateHitbox()
    {
        Collider2D c = GetComponent<Collider2D>();
        c.enabled = false;

        yield return new WaitForSeconds(0.5f);
        c.enabled = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Enemy") || other.CompareTag("EnemyBullet"))
        {
            Destroy(other.gameObject);
        }
        
        if(other.CompareTag("Enemy"))//animasi ledakan
        {
            GameManager.instance.AddScore(10);
            AudioManager.Instance.PlaySFX(AudioManager.Instance.boomSFXClip);
            GameObject explosion = Instantiate(explosionPrefab, other.transform.position, Quaternion.identity);
            Destroy(explosion, 1f);
        }
    }

}
