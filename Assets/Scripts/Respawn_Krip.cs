using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn_Krip : MonoBehaviour {
    
    public GameObject krip;
    public Transform transform_Tower;
    public Transform transform_Player;
    GameObject clone;

    void Start()
    {
        clone = Instantiate(krip, transform.position, Quaternion.identity) as GameObject;
    }

    void Update()
    {
        if (Math.Abs(transform_Player.position.x - clone.transform.position.x) < 50.0F)
        {
            if (Math.Abs(transform_Player.position.x - clone.transform.position.x) > 10.0F)
            {
                clone.transform.position = Vector3.MoveTowards(clone.transform.position, new Vector3(transform_Player.position.x, clone.transform.position.y, clone.transform.position.z), Time.deltaTime*4);
            }
            else
            {
                ;
            }
        }
        else
        {
            if (Math.Abs(clone.transform.position.x - transform_Tower.position.x) > 10.0F)
            {
                clone.transform.position = Vector3.MoveTowards(clone.transform.position, new Vector3(transform_Tower.position.x, clone.transform.position.y, clone.transform.position.z), Time.deltaTime*4);
            }
            else
            {
                ;
            }
        }
    }
}
