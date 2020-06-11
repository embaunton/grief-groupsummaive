using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notice : MonoBehaviour
{
    public bool seen;
    // Start is called before the first frame update
    void Start()
    {
        seen = false;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Friend")
        {
            seen = true;
        }
    }private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Friend")
        {
            seen = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
