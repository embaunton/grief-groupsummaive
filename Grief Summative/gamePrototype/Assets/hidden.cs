using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hidden : MonoBehaviour
{
    public GameObject fog;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            fog.SetActive(false);
            //Destroy(gameObject);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            fog.SetActive(true);
            //Destroy(gameObject);
        }
    }
    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
            //Destroy(gameObject);
        }
    }
      private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            gameObject.SetActive(true);
            //Destroy(gameObject);
        }
        
    }*/
    // Update is called once per frame
    void Update()
    {
        
    }
}
