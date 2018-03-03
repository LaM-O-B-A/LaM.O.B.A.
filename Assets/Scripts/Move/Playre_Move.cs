using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playre_Move : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x - 1.0F, transform.position.y, transform.position.z), Time.deltaTime*5);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x + 1.0F, transform.position.y, transform.position.z), Time.deltaTime*5);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y + 1.0F, transform.position.z), Time.deltaTime*5);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y - 1.0F, transform.position.z), Time.deltaTime*5);
        }
    }
}
