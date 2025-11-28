using UnityEngine;

public class PlayerShoot2D : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float shootForce = 10f;

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) 
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            rb.AddForce(firePoint.right * shootForce, ForceMode2D.Impulse);
        }

        bullet.transform.rotation = Quaternion.Euler(0, 0, -90);
    }
}
