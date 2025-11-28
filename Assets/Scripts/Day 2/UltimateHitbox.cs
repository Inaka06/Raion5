using UnityEngine;
using System.Collections;

public class UltimateHitbox : MonoBehaviour
{
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
            GameObject explosion = Instantiate(explosionPrefab, other.transform.position, Quaternion.identity);
            Destroy(explosion, 1f);
        }
    }

}
