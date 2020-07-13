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
    float bottomLimit;
    float topLimit;
    float rightLimit;
    float leftLimit;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();

        Vector3 bottomleft = Camera.main.ViewportToWorldPoint(Vector3.zero);
        bottomLimit = bottomleft.y;
        leftLimit = bottomleft.x;

        Vector3 topright = Camera.main.ViewportToWorldPoint(Vector3.one);
        topLimit = topright.y;
        rightLimit = topright.x;

        bottomLimit += renderer.bounds.extents.y;
        topLimit -= renderer.bounds.extents.y;
        leftLimit += renderer.bounds.extents.x;
        rightLimit -= renderer.bounds.extents.x;

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
        Vector3 desiredposition = transform.position + new Vector3(x, y, 0f) * speed * Time.fixedDeltaTime;

        desiredposition.x = Mathf.Clamp(desiredposition.x, leftLimit, rightLimit);

        desiredposition.y = Mathf.Clamp(desiredposition.y, bottomLimit, topLimit);

        rb.MovePosition(desiredposition);
    }
  
}
