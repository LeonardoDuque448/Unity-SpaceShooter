using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletB : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 20f;
    public float DamageAmaount = 10f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.up * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
     
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerHp player = collision.gameObject.GetComponent<PlayerHp>();
            if (player != null)
            {

                player.Damage(DamageAmaount);
                Destroy(this.gameObject);


            }

        }
    }
}
