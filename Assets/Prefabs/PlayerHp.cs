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
    public GameObject Deathparticleprefab;

    public AudioClip disparo;

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

            Death();
        }
    }
    private void shoot() 
    {
        GameObject particle = Instantiate(bulletprefab, bulletorigin.position, bulletorigin.rotation);
        TimeOfLastShot = Time.time;

        AudioSource.PlayClipAtPoint(disparo, Camera.main.transform.position, 1f);
    }

    private void Death() 
    {
        Instantiate(Deathparticleprefab, transform.position, transform.rotation);

        FindObjectOfType<GameManager>().GameOver();
        Destroy(this.gameObject);


    }
}
