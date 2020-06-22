using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorito : MonoBehaviour
{
    public float speed = 1f;

    private Rigidbody2D rb;

    //private void Awake()
    //{
       
    //}
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.down;
    }

    // Update is called once per frame
    void Update()
    {

        //transform.position += new Vector3(0f, -1f, 0f) * speed * Time.deltaTime;


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
    }
}
