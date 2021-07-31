using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jk53 : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public float jumpforce;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        float horizontalmove = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(horizontalmove * speed, rb.velocity.y);
        if (horizontalmove != 0) //¨¤¦âÂà¨­ 
        {
            transform.localScale = new Vector3(horizontalmove, 1, 1);
        }
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpforce * Time.deltaTime);
        }

    
    
    }
}