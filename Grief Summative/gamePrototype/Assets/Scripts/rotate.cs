using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.Rotate(0.0f, 0.0f, -90.0f);
           // transform.rotation = Quaternion.Slerp(transform.rotation.y,transform.rotation.y+90, 1 * Time.deltaTime);

        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.Rotate(0.0f, 0.0f, 90.0f);
           

        }
    }
}
