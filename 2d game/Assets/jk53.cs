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
        //���Ⲿ��
        float horizontalmove = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(horizontalmove * speed, rb.velocity.y);
        anim.SetFloat("�����}��0", Mathf.Abs(horizontalmove));
        if (horizontalmove != 0) //�����ਭ 
        {
            transform.localScale = new Vector3(horizontalmove, 1, 1);
        }
        if (Input.GetButtonDown("Jump"))//�}���
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpforce * Time.deltaTime);
            anim.SetBool("���}��", true);
        }
    }

    void SwitchAnim()
    {
        anim.SetBool("�ݾ��}��", false);

        if (anim.GetBool("���}��"))
        {
            if (rb.velocity.y < 0)
            {
                anim.SetBool("���}��", false);
                anim.SetBool("���U�}��", true);
            }
        }else if (coll.IsTouchingLayers(ground))
        {
            anim.SetBool("���U�}��", false);
            anim.SetBool("�ݾ��}��", true);
        }
        
    }
}