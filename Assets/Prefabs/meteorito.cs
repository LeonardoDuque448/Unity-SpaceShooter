using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorito : MonoBehaviour
{
    public float speed = 1f;
    public float DamageAmaount = 10f;

    public GameObject Particleprefab;

    private Rigidbody2D rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.down * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerHp player = collision.gameObject.GetComponent<PlayerHp>();

            if (player != null)
            {

                player.Damage(DamageAmaount);
                Destroymeteoro();

            }
        }


    }
    public void Destroymeteoro()
    {
        GameObject particles = Instantiate(Particleprefab, transform.position, transform.rotation);
        Destroy (particles,5f);
        Destroy(this.gameObject);
    }
}