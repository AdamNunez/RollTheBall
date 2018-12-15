using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider other)
    {
        GameObject p = GameObject.FindGameObjectWithTag("Player");
        p.transform.position = new Vector3(0, 61.7f, 0);
        p.GetComponent<Rigidbody>().velocity = Vector3.zero;
        p.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        p.GetComponent<Rigidbody>().angularDrag = 0f;

        GameObject rotatorSquare = GameObject.FindGameObjectWithTag("CameraRotatorArea");
        CameraRotator r = rotatorSquare.GetComponent<CameraRotator>();
        r.cameraRotated = false;
        r.playerRotated = false;

        GameObject c = GameObject.FindGameObjectWithTag("Camera");
        c.transform.eulerAngles = new Vector3(45, 0, 0);
        CameraController controller = c.GetComponent<CameraController>();
        controller.offsetX = new Vector3(0, 2, -2.1f);
    }
}
