using Assets.Scripts.Controller;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    Vector3 move;
    // Use this for initialization
    void Start () {
        Input.gyro.enabled = true;
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    void FixedUpdate()
    {
        if (Application.platform == RuntimePlatform.Android)
            move = new Vector2(Input.gyro.rotationRateUnbiased.x, Input.gyro.rotationRateUnbiased.y);
        else
           move = new MovementController().MoveByAxis();
        Rigidbody bod = GetComponent<Rigidbody>();
        //if(Vector3.zero == cameraRotation)
        //{
        //    bod.AddForce(move * speed);
        //}
        //else
        //{
        var camera = GameObject.FindGameObjectWithTag("Camera");
        var forward = camera.transform.forward;
        var right = camera.transform.right;

        forward.y = 0;
        right.y = 0;
        forward.Normalize();
        right.Normalize();

        Vector3 desiredMoveDirection = forward * move.z + right * move.x;

        bod.AddForce(desiredMoveDirection* speed * Time.deltaTime * 20);
            
        //}
        

    }
}
