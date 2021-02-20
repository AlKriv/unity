using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{

    Rigidbody2D rb;
    public float speed;
    public float jumpHeight;
    public Transform groundCheck;
    public bool isGrounded;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        //CheckGround();
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
            rb.AddForce(transform.up * jumpHeight, ForceMode2D.Impulse);
        if (Input.GetAxis("Horizontal")==0 && (isGrounded))
        {
            anim.SetInteger("state", 1);
        }
        else
        {
            Flip();
            if (isGrounded)
                anim.SetInteger("state", 2);
        }
    }

    void FixedUpdate()
    {
    
        //move to the left/right
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);
        

    }
    void Flip()
    {
           //разворот объекта в зависимости от направления движения
        if (Input.GetAxis("Horizontal") > 0)
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        if (Input.GetAxis("Horizontal") < 0)
            transform.localRotation = Quaternion.Euler(0, 180, 0);
    }

    //void CheckGround()
    //{
    //    Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheck.position, 0.2f);
    //    isGrounded = colliders.Length > 1;
    //}
}
