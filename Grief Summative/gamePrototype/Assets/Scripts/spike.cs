using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spike : MonoBehaviour
{
    public GameObject spawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            print("tag");
            // Destroy(collision.gameObject);
            collision.gameObject.transform.position = spawn.transform.position;
        }
    }
    
    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            print("tag");
           // Destroy(collision.gameObject);
            collision.gameObject.transform.position = spawn.transform.position;
        }
    }*/
  
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
