using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    //void OnGUI()
    //{
    //    Screen.lockCursor = true;
    //}

    void Start()
    {

    }

    bool flag = false;
    Quaternion target;
    int raz_X = 0, raz_Y = 0, lastMousePosition_X = 0, lastMousePosition_Y = 0;
    public Camera camera;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            camera.orthographicSize += 0.1F;
        }

        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            camera.orthographicSize -= 0.1F;
        }

        if ((int)Input.mousePosition.x >= camera.pixelWidth)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x + 10.0F, transform.position.y, transform.position.z), Time.deltaTime * 5);
        }

        if ((int)Input.mousePosition.x <= 0 && (int)Input.mousePosition.x <= camera.pixelWidth)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x - 10.0F, transform.position.y, transform.position.z), Time.deltaTime * 5);
        }

        if ((int)Input.mousePosition.y >= camera.pixelHeight)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y + 10.0F, transform.position.z), Time.deltaTime * 5);
        }

        if ((int)Input.mousePosition.y <= 0 && (int)Input.mousePosition.y <= camera.pixelHeight)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y - 10.0F, transform.position.z), Time.deltaTime * 5);
        }


        //if (Input.GetKeyDown(KeyCode.Mouse1))
        //{
        //    flag = true;
        //    lastMousePosition_X = (int)Input.mousePosition.x;
        //    lastMousePosition_Y = (int)Input.mousePosition.y;
        //}

        //Debug.Log((int)Input.mousePosition.x + (int)Input.mousePosition.y + "\n");

        //if (Input.GetKeyUp(KeyCode.Mouse1))
        //{
        //    flag = false;
        //    lastMousePosition_X = (int)Input.mousePosition.x;
        //    lastMousePosition_Y = (int)Input.mousePosition.y;
        //}

        //if (Input.GetKey(KeyCode.Mouse1) && flag)
        //{
        //    raz_X += (int)Input.mousePosition.x - lastMousePosition_X;
        //    raz_Y += (int)Input.mousePosition.y - lastMousePosition_Y;

        //    target = Quaternion.Euler((int)transform.rotation.x - raz_Y / 4, (int)transform.rotation.y + raz_X / 4, 0);
        //    transform.rotation = Quaternion.Slerp(transform.rotation, target, 0.3F);

        //    lastMousePosition_X = (int)Input.mousePosition.x;
        //    lastMousePosition_Y = (int)Input.mousePosition.y;
        //}
    }
}
