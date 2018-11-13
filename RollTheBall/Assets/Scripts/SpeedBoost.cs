using Assets.Scripts.Controller;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider other)
    {
        PlayerController p = other.gameObject.GetComponent<PlayerController>();
        Debug.Log(p.ToString());
        Rigidbody b = p.GetComponent<Rigidbody>();
        Debug.Log(b.ToString());
        Vector3 move = new MovementController().MoveByAxis();
        b.AddForce(p.speed * 20 * move);
        
    }
}
