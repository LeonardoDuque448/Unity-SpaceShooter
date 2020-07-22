using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public float hpmax = 50f;
    public float currentHP;
    public float timeBetweenShots = 1.0f;
    public GameObject bulletprefab;
    public Transform bulletorigin;
    private float TimeOfLastShot;
    public float speed = 1f;
    public float DamageAmaount = 10f;
    public GameObject Particleprefab2;

    private Rigidbody2D rb;

    public void Start()
    {
        currentHP = hpmax;
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.down * speed;
    }
    public void Update()
    {
        
        
            if (Time.time > TimeOfLastShot + timeBetweenShots)
                shoot();


        
    }
    public void Damage(float amount)
    {
        currentHP -= amount;

        if (currentHP <= 0f)
        {

         DestroyEnemy();
        }
    }
    private void shoot()
    {
        Instantiate(bulletprefab, bulletorigin.position, bulletorigin.rotation);
        TimeOfLastShot = Time.time;
    }
    public void DestroyEnemy()
    {
        GameObject particula = Instantiate(Particleprefab2, transform.position, transform.rotation);
        Destroy(particula, 5f);
        Destroy(this.gameObject);
    }
}
