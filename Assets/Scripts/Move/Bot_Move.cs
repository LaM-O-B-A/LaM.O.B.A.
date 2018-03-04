using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot_Move : MonoBehaviour {

    public Transform transform_Tower;
    public Transform transform_Player;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Math.Abs(transform_Player.position.x - transform.position.x) < 50.0F)
        {
            if (Math.Abs(transform_Player.position.x - transform.position.x) > 10.0F)
            {
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform_Player.position.x, transform.position.y, transform.position.z), Time.deltaTime*5);
            }
            else
            {
                ;
            }
        }
        else
        {
            if (Math.Abs(transform.position.x - transform_Tower.position.x) > 10.0F)
            {
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform_Tower.position.x, transform.position.y, transform.position.z), Time.deltaTime*5);
            }
            else
            {
                ;
            }
        }
    }
}
