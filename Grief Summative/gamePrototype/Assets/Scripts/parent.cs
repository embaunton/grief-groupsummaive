using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parent : MonoBehaviour
{
    public GameObject player;
    public follow follow;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private IEnumerator flip()
    {
        transform.parent = player.transform;
        yield return new WaitForSeconds(1.0f * Time.deltaTime);
        transform.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (follow.turn==false)
        {
            transform.parent = player.transform;
        }
        else
        {
            transform.parent = null;
        }
    }
}
