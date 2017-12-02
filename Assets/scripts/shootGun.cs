using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootGun : MonoBehaviour {

	public GameObject projectile;
	float speed = 100f;
	float rate = 0.35f;
	float counter = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("z") && counter > rate) {
			Transform camera = GetComponentInParent<Transform> ();
			print (camera.position + "dawd");
			GameObject bullet = Instantiate(projectile, camera.position, Quaternion.identity) as GameObject;
			bullet.GetComponent<Rigidbody>().AddForce(camera.forward * 1000);
			counter = 0f;
		}
		counter += Time.deltaTime;
	}
}
