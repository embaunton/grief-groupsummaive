using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject target;
    public Vector3 offset;
    public float speed = 1.80f;

    // Start is called before the first frame update
    void Start()
    {
        
        //offset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position ,speed*Time.deltaTime);
    }
}
