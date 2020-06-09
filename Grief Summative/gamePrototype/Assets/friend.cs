using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class friend : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public Vector3 point;
    public float speed;
    public bool inSight;
    public move move;
    public bool set;
    public bool act;
    public GameObject way;
    public GameObject notice;
    public GameObject pos;
    public Rigidbody2D rb;
    public Vector3 vel;

    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
       // move = target.GetComponent<move>();
        inSight = false;
        target = null;
    }
   /* private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            act = false;
            set = false;
            inSight = true;
            target = collision.transform;
            //   transform.parent = null;
            
        }
        if (collision.gameObject.tag == "Glass")
        {
            if (vel.y > 1.0 || vel.y < -1.0f)
            {
                Destroy(collision.gameObject);
            }
        }
    }*/
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            act = false;
            set = false;
            inSight = true;
            target = collision.transform;
            //   transform.parent = null;
        }
        if (collision.gameObject.tag == "Glass")
        {
            if (vel.y > 1.0 || vel.y < -1.0f)
            {
                Destroy(collision.gameObject);
            }
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //target = null;
            // gameObject.transform.parent = collision.gameObject.transform;
        }
        if (collision.gameObject.tag == "Spike")
        {
            Destroy(collision.gameObject, 0.1f * Time.deltaTime);
          //  gameObject.transform.position = spawn.transform.position;
        }
         /* 
        if (collision.gameObject.tag == "Glass")
        {
            if (vel.y > 1.26f || vel.y < -1.26f)
            {
                Destroy(collision.gameObject);
            }
        }
        */
        if (collision.gameObject.tag == "Switch")
        {

        }
    }
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // target = null;
            set = true;
        }
    }
   

    /*private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            target = null;
            inSight = false;
        }
    }*/

    // Update is called once per frame
    void Update()
    {
        vel = rb.velocity;
        if(target != null)
        {
            move = target.GetComponent<move>();
            Physics2D.IgnoreCollision(target.GetComponent<BoxCollider2D>(), GetComponent<Collider2D>());
          //  Physics2D.IgnoreCollision(notice.GetComponent<CircleCollider2D>(), GetComponent<Collider2D>());
        }
       // Physics2D.IgnoreCollision(target.GetComponent<BoxCollider2D>(), GetComponent<Collider2D>());
        point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        point.z = 0;
       // move = target.GetComponent<move>();
        if (inSight && move.space == true && target != null && !act && !set)
        {
            transform.rotation = (Quaternion.Slerp(transform.rotation, target.transform.rotation, speed * Time.deltaTime));
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
        }
      
        //transform.rotation = (Quaternion.Slerp(transform.rotation, target.transform.rotation, speed * Time.deltaTime));
        if (Input.GetMouseButton(0)&& set)
        {
            rb.bodyType = RigidbodyType2D.Kinematic;
           // act = true;
            //set = false;
            //way = Instantiate(way, point, Quaternion.identity);
            //point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        } if (Input.GetMouseButtonUp(0)&&set )
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
            act = true;
            set = false;
            pos = Instantiate(way, point, Quaternion.identity);
            //target = pos.transform;
            //point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        if (act && pos != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, pos.transform.position, speed * Time.deltaTime);
        }
        if (pos == null)
        {
            //set = true;
            act = false;
        }
        
        /*if (transform.position != pos.transform.position)
        {
            set = true;
            act = false;
            pos = null;
            
        }*/
    }
    private void FixedUpdate()
    {
      //  vel = rb.velocity;
    }
}
