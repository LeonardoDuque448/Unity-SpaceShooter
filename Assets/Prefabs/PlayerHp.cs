using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHp : MonoBehaviour
{
    public float hpmax = 100f;
    public float currentHP;
    public float timeBetweenShots = 0.2f;
    public GameObject bulletprefab;
    public Transform bulletorigin;
    private float TimeOfLastShot;

    public void Start()
    {
        currentHP = hpmax;
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Time.time > TimeOfLastShot + timeBetweenShots)
                shoot();

           
        }
    }
    public void Damage(float amount)
    {
        currentHP -= amount;

        
        if (currentHP <= 0f)
        {
            Debug.Log("game over");
            Destroy(this.gameObject);
        }
    }
    private void shoot() 
    {
        Instantiate(bulletprefab, bulletorigin.position, bulletorigin.rotation);
        TimeOfLastShot = Time.time;
    }
}
