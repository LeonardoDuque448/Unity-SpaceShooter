using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5f;
    private Rigidbody2D rb;

    float x;
    float y;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }
    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        //transform.position += new Vector3(x, y, 0f) * speed * Time.deltaTime;

        //rb.velocity = new Vector2(x, y) * speed;
        
    }
    private void FixedUpdate()
    {
        rb.MovePosition(transform.position + new Vector3(x, y, 0f) * speed * Time.deltaTime);
    }
  
}
