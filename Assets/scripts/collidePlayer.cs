using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collidePlayer : MonoBehaviour {

	GameController GC;

	// Use this for initialization
	void Start () {
		GC = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Player") {
			print ("collide with kidney");
			GC.addPoint ();
			Destroy (this.gameObject);
		} 
			
	}
}
