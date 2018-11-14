using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider other)
    {
        PlayerController p = other.GetComponent<PlayerController>();
        Rigidbody b = p.GetComponent<Rigidbody>();
        b.velocity = Vector3.zero;

        b.angularVelocity = Vector3.zero;
        
        b.Sleep();
    }
}
