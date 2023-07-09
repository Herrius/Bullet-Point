using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour
{
    public float rotationSpeed = 10f;  // Velocidad de rotación de la torreta
    public GameObject bulletPrefab;  // Prefab del proyectil
    public float bulletSpeed = 10f;  // Velocidad del proyectil
    public Transform firePoint;  // Punto desde donde se disparará el proyectil
    public AudioSource audioSource;
    public AudioClip fireSound;

    void Update()
    {
        RotateTurret();
        if (Input.GetMouseButtonDown(0))  // 0 corresponde al botón izquierdo del mouse
        {
            Fire();
        }
    }

    void RotateTurret()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = new Vector2(
            mousePos.x - transform.position.x,
            mousePos.y - transform.position.y
        );
        transform.up = direction;
    }

    void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bullet.GetComponent<Rigidbody2D>().velocity = bullet.transform.up * bulletSpeed;
        audioSource.Play();
        audioSource.PlayOneShot(fireSound);
    }
}
