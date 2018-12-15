using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    private Vector3 rotationOffset;

    public float turnSpeed = 4.0f;
    public Transform player;

    public float height = 1f;
    public float distance = 2f;

    public Vector3 offsetX;

    public Joystick joystick;

    void Start()
    {

        offsetX = new Vector3(0, height, -distance);
    }

    void LateUpdate()
    {
        //if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
            offsetX = Quaternion.AngleAxis(-joystick.Horizontal * turnSpeed, Vector3.up) * offsetX;
        //offsetX = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * offsetX;
        transform.position = player.position + offsetX;
        transform.LookAt(player.position);
    }
}