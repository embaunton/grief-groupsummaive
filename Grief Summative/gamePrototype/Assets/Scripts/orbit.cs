using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbit : MonoBehaviour
{
    public Transform target;
    public float orbitDistance = 10.0f;
    public float orbitDegreesPerSec =10.0f;
    public Vector3 relativeDistance = Vector3.zero;
    public Vector3 pivot;
    public bool leftTurn;
    public bool rightTurn;
    public bool turn;

    void Start()
    {
        pivot = transform.rotation.eulerAngles;

        leftTurn = false;
        rightTurn = false;
        turn = true;

    }

    void left()
    {
       
         
            transform.position = target.position + relativeDistance;
            transform.RotateAround(target.position, Vector3.forward, orbitDegreesPerSec * Time.deltaTime);
            // Reset relative position after rotate
            relativeDistance = transform.position - target.position;
      
    }  void right()
    {
       
            
            transform.position = target.position + relativeDistance;
            transform.RotateAround(target.position, -Vector3.forward, orbitDegreesPerSec * Time.deltaTime);
            // Reset relative position after rotate
            relativeDistance = transform.position - target.position;
        
    }
    private void Update()
    {//rotate action
        if (rightTurn)
        {
            right();
        }
        else if (!rightTurn)
        {

        } 
        if (leftTurn)
        {
            left();
        }
        else if (!leftTurn)
        {

        }
        //rotate trigger
            if (Input.GetKeyDown(KeyCode.E)&&(turn))
        {
            turn = false;
            pivot = transform.rotation.eulerAngles;
            rightTurn = true;
            relativeDistance = transform.position - target.position;
            //right();
        }
      
        if (Input.GetKeyDown(KeyCode.Q) && (turn))
        {
            turn = false;
            pivot = transform.rotation.eulerAngles;
            leftTurn = true;
            relativeDistance = transform.position - target.position;
           // left();

        }
        //rotate clamp
        if (pivot.z >= gameObject.transform.rotation.eulerAngles.z +90 || pivot.z <= gameObject.transform.rotation.eulerAngles.z  - 90)
        {
            turn = true;
            rightTurn = false;
            leftTurn = false;
            //pivot = Vector3.zero;
            /*if (gameObject.transform.rotation.eulerAngles.z > 91 || gameObject.transform.rotation.eulerAngles.z < 89)
            {
                gameObject.transform.Rotate( 0,0,15.0f * Time.deltaTime);
            }
            if (gameObject.transform.rotation.eulerAngles.z > 1 || gameObject.transform.rotation.eulerAngles.z < -1)
            {
                gameObject.transform.Rotate(0, 0, 15.0f * Time.deltaTime);
            } 
            if (gameObject.transform.rotation.eulerAngles.z > 181|| gameObject.transform.rotation.eulerAngles.z < 179)
            {
                gameObject.transform.Rotate(0, 0, 15.0f * Time.deltaTime);
            }
            if (gameObject.transform.rotation.eulerAngles.z > 136 || gameObject.transform.rotation.eulerAngles.z < 134)
            {
                gameObject.transform.Rotate(0, 0, 15.0f * Time.deltaTime);
            }*/
        }
    }
 
}
