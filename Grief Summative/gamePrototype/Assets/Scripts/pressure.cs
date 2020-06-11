using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressure : MonoBehaviour
{
    public GameObject barrier;
    public float timer;
    void Start()
    {
        
    }
    private void OnCollisionStay2D(Collision2D collision)
    {//* on event destroy barrier in x amount of time
        //if collider is not kinetic...  (( gameObject.tag!="Obj"))
        if(barrier!= null && collision.gameObject.tag != "Obj")
        {
            Destroy(barrier,timer*Time.deltaTime);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
