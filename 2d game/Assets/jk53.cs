using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jk53 : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator anim;
    public Collider2D coll;
    public float speed;
    public float jumpforce;
    public LayerMask ground;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
        SwitchAnim();
    }

    void Movement()
    {
        //角色移動
        float horizontalmove = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(horizontalmove * speed, rb.velocity.y);
        anim.SetFloat("走路開關0", Mathf.Abs(horizontalmove));
        if (horizontalmove != 0) //角色轉身 
        {
            transform.localScale = new Vector3(horizontalmove, 1, 1);
        }
        if (Input.GetButtonDown("Jump"))//腳色跳
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpforce * Time.deltaTime);
            anim.SetBool("跳開關", true);
        }
    }

    void SwitchAnim()
    {
        anim.SetBool("待機開關", false);

        if (anim.GetBool("跳開關"))
        {
            if (rb.velocity.y < 0)
            {
                anim.SetBool("跳開關", false);
                anim.SetBool("落下開關", true);
            }
        }else if (coll.IsTouchingLayers(ground))
        {
            anim.SetBool("落下開關", false);
            anim.SetBool("待機開關", true);
        }
        
    }
}