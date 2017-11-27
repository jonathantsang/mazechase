using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterScream : MonoBehaviour {

	private Transform player;
	float screamdist = 5f;
	AudioSource AS;
	public AudioClip scream1;
	public AudioClip scream2;
	public AudioClip scream3;
	List<AudioClip> screams;
	float resetsound = 0f;

	// Use this for initialization
	void Start () {
		AS = GetComponent<AudioSource> ();
		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform> ();
		screams = new List<AudioClip> () { scream1, scream2, scream3 };
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance (transform.position, player.position) <= screamdist && resetsound > 5) {
			int randsound = Random.Range (0, 3);
			AS.clip = screams [randsound];
			AS.Play ();
			print ("monster sounds");
			print (randsound + " num");
			resetsound = 0f;
		}
		resetsound += Time.deltaTime;
	}
}
