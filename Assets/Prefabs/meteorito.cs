﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorito : MonoBehaviour
{
    public float speed = 1f;
    public float DamageAmaount = 10f;

    private Rigidbody2D rb;

   
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.down * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerHp player = collision.gameObject.GetComponent<PlayerHp>();
           
            if (player != null)
            {
                Debug.Log("collision");
                player.Damage(DamageAmaount);
                Destroy(this.gameObject);

            }
        }

        
    }
}
