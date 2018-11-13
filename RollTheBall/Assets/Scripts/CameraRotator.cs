using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotator : MonoBehaviour {
    public float XRotation, YRotation, ZRotation;
    public bool cameraRotated = false;
    public bool playerRotated = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void OnTriggerEnter(Collider other)
    {
        var c = GameObject.FindGameObjectWithTag("Camera");
        if(c != null && c.transform != null && !cameraRotated)
        {
            Vector3 pos = c.transform.eulerAngles;
            pos.x += XRotation;
            pos.y += YRotation;
            pos.z += ZRotation;
            c.transform.eulerAngles = pos;

            cameraRotated = true;
        }

        //var p = GameObject.FindGameObjectWithTag("Player");
        //if (p != null && p.transform != null && !playerRotated)
        //{
        //    p.GetComponent<PlayerController>().cameraRotation = new Vector3(XRotation, YRotation, ZRotation);
        //    playerRotated = true;
        //}

    }
}
