using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveTowardsPlayer : MonoBehaviour {

	private Transform player;
	public float speed = 1;
	int MinDist = 1;
	int MaxDist = 10;
	float step;

	// Use this for initialization
	void Start () {
		step =  speed * Time.deltaTime;
		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		 transform.LookAt(player);
 
         if (Vector3.Distance(transform.position, player.position) >= MinDist)
         {
 
             transform.position += transform.forward * speed * Time.deltaTime;
 
 
             if (Vector3.Distance(transform.position, player.position) <= MaxDist)
             {
                 //Here Call any function U want Like Shoot at here or something
             }
 
         }
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Player") {
			// Die
			print("dead");
			SceneManager.LoadScene("lose");
		}
	}
}