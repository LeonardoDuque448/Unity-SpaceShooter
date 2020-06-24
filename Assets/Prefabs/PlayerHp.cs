using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHp : MonoBehaviour
{
    public float hpmax = 100f;
    public float currentHP;
    public float timeBetweenShots = 0.2f;
    public GameObject bulletprefab;
    public Transform bulletorigin;
    private float TimeOfLastShot;
    public Text HPText;

    public void Start()
    {
        currentHP = hpmax;
        HPText.text = "shields: " + currentHP;
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
        HPText.text = "shields: " + currentHP;
        
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
