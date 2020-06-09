using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float jump = 500.0f;
    public float speed = 1.26f;
    public Rigidbody2D rb;
    public Vector2 move;
   // Animator anim;
    public bool right;
    public Vector3 mirror;
    public bool ground;
    // Start is called before the first frame update
    void Start()
    {
        mirror = transform.localScale;
        // press = false;
        right = true;
        rb = GetComponent<Rigidbody2D>();
       // anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ground = true;
     //   anim.SetBool("ground", true);
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        ground = false;
      //  anim.SetBool("ground", false);
    }
    // Update is called once per frame
    void Update()
    {
        move.x = Input.GetAxis("Horizontal");
        move.y = Input.GetAxis("Vertical");
       // anim.SetFloat("horizontal", move.x);
       // anim.SetFloat("speed", move.sqrMagnitude);
       
        rb.MovePosition(rb.position + move * speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && ground==true )
        {
            rb.AddForce(Vector2.up * jump);
            
          //  anim.SetTrigger("jump");
        }
        if (Input.anyKey)
        {
            //right = true;
        }
        else
        {
            //press = false;
        }
        if (move.x < 0.0f )
        {
            right = false;
           // mirror.x *= -1;
           // anim.SetBool("left", true);
           // anim.SetBool("right", false);
        }
        else
        {
           // anim.SetBool("left", false);
        }
        if (move.x > 0.0f)
        {
            right = true;
            //transform.localScale = mirror;
           // anim.SetBool("right", true);
           // anim.SetBool("left", false);
        }
        else
        {
           //anim.SetBool("right", false);
        }
        if (((right)&&(mirror.x <0))|| ((!right) && (mirror.x > 0)))
        {
            mirror.x *= -1;
        }
        transform.localScale = mirror;
    }
}
