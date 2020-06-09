using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glass : MonoBehaviour
{
    public move move;
    public Rigidbody2D rb;
    public Vector3 vel;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb = collision.rigidbody;
       // vel = rb.velocity;
        if(vel.y <= -1.53f || vel.y >= 1.53f)
        {
            Destroy(gameObject);
        }
        /*if(move.vel.y <= -1.53f|| move.vel.y >=1.53f)
        {
        
            Destroy(gameObject);
        }*/
    }
    // Update is called once per frame
    void Update()
    {
        /*if (rb != null)
        {
            vel = rb.velocity;
        }*/
    }
    private void FixedUpdate()
    {
        if (rb != null)
        {
            vel = rb.velocity;
        }
    }
}
