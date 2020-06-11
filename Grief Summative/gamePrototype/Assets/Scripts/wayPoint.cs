using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wayPoint : MonoBehaviour
{
    public GameObject Parent;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.parent = Parent.transform;
        gameObject.SetActive(true);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Friend")
        {
           // gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject,500.0f*Time.deltaTime);
    }
}
