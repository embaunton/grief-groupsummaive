using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public GameObject trace;
    public bool turn;
    public Vector3 pivot;
    public Vector3 traceP;

    // Start is called before the first frame update
    void Start()
    {
        turn = true;
    }

    // Update is called once per frame
    void Update()
    {
        pivot = transform.rotation.eulerAngles;
        traceP = trace.transform.rotation.eulerAngles;
       
            
            transform.rotation = (Quaternion.Lerp(transform.rotation, trace.transform.rotation, 10.0f * Time.deltaTime));
        
        if(pivot == traceP)
        {
            turn = true;
        }
        else
        {
            turn = false;
        }
    }
}
