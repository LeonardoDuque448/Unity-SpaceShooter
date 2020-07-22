using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public float DamageAmaount = 10f;
    private Rigidbody2D rb;
    public GameObject Hitparticle;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.up * speed;
    }
    
  
     private void OnTriggerEnter2D(Collider2D collision)
     {
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            EnemyHP enemigo = collision.gameObject.GetComponent<EnemyHP>();
            if (enemigo != null)
            {

                FindObjectOfType<Score>().addpoints(25);
                enemigo.Damage(DamageAmaount);
                Destroy(this.gameObject);

            }

        }
        if (collision.gameObject.CompareTag("meteoro"))
        {
            meteorito Meteorito = collision.gameObject.GetComponent<meteorito>();
            if (Meteorito != null)
            {

                FindObjectOfType<Score>().addpoints(10);
                Meteorito.Destroymeteoro();
                
                GameObject particles = Instantiate(Hitparticle, transform.position, transform.rotation);
                Destroy(particles, 5f);
                Destroy(this.gameObject);
            }

           
        }
     }



}


       
