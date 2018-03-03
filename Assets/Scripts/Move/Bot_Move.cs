using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot_Move : MonoBehaviour {

    public Transform transform_Order;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(transform.position.x - transform_Order.position.x > 10.0F)
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform_Order.position.x, transform.position.y, transform.position.z), Time.deltaTime);
	}
}
