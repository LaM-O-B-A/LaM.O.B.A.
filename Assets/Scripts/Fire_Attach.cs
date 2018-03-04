using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_Attach : MonoBehaviour {

    public Transform transform_Object;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform_Object.position.x, transform_Object.position.y, transform.position.z), 0);
    }
}
