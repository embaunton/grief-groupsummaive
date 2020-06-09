using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed;
    public float jump;
    public GameObject spawn;

    public Rigidbody2D rb;
    public orbit orbit;
    public follow follow;
    public bool ground;
    public bool space;
    public bool xJump;
    public Vector3 vel;
    // Start is called before the first frame update
    void Start()
    {
        space = true;
        // vel = rb.velocity;
        xJump = true;
        ground = false;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Friend")
        {
            space = false;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Friend")
        {
            space = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Spike")
        {
            gameObject.transform.position = spawn.transform.position;
        } 
     //  /* 
         if (collision.gameObject.tag == "Glass")
        {
            if (vel.y > 1.53f || vel.y < -1.53f)
            {
                Destroy(collision.gameObject);
            }
        }
        //*/
        if (collision.gameObject.tag == "Switch")
        {

        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        
            xJump = true;
            ground = true;
        
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obj")
        {
            ground = false;
        }
    }
    void Update()
    {
      

        //speed moving
        vel = rb.velocity;
        //velocity speed limit
        if (vel.y > 1.8f)
        {
            vel.y = 1.8f;
        }
        else
        {

        } if (vel.y < -1.8f )
        {
            vel.y = -1.8f;
        }
        else
        {

        }
        //pause character while turning
        if (orbit.turn == false)
        {
            rb.bodyType = RigidbodyType2D.Kinematic;
        }
        else
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
        }
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime,0.0f, 0.0f);
        if (Input.GetKeyDown(KeyCode.W)&&(ground))
        {
            rb.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.W)&& (!ground) &&(xJump)&& (vel.magnitude >0.01f))
        {
            rb.AddForce(Vector2.up * jump*1.5f, ForceMode2D.Impulse);
            xJump = false;
        }
    }
}
