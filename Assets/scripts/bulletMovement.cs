using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMovement : MonoBehaviour {

	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		Destroy (this.gameObject, 4);
	}
	
	// Update is called once per frame
	void Update () {
		//Vector3 newpos = transform.forward + rb.position;
		//rb.MovePosition (newpos);
	}

	void OnCollisionEnter(Collision col){
		Destroy (this.gameObject);
	}
}
