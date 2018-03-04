using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_Tower : MonoBehaviour {

    public GameObject Fire;
    public Transform transform_Krip;
    public Transform transform_Player;
    GameObject clone;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update ()
    {
        Debug.Log(transform_Krip.name + "      " + transform.name + "\n");
        Debug.Log(transform_Player.name + "      "  + transform.name + "\n");
        if (Math.Abs(transform_Player.position.x - transform.position.x) < 15.0F)
        {
            clone = Instantiate(Fire, transform.position, Quaternion.identity) as GameObject;
            clone.transform.position = Vector3.MoveTowards(clone.transform.position, new Vector3(transform_Player.position.x, clone.transform.position.y, clone.transform.position.z), Time.deltaTime*7);
        }
        else if(Math.Abs(transform.position.x - transform_Krip.position.x) < 15.0F)
        {
            clone = Instantiate(Fire, transform.position, Quaternion.identity) as GameObject;
            clone.transform.position = Vector3.MoveTowards(clone.transform.position, new Vector3(transform_Krip.position.x, clone.transform.position.y, clone.transform.position.z), Time.deltaTime*7);
        }
    }
}
