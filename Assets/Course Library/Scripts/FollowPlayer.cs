using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);

    private bool nearView = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            nearView = !nearView;
        }

        if (nearView)
        {
            offset = new Vector3(0, 2, 1);
        }
        else
        {
            offset = new Vector3(0, 5, -10);
        }
        transform.position = player.transform.position + offset;
    }
    
    
}
