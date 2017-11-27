using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScarySounds : MonoBehaviour {

    public AudioClip scary1;
    public AudioClip scary2;
    public AudioClip scary3;
    public AudioClip scary4;
    public AudioClip scary5;
    public AudioClip scary6;
    public AudioClip scary7;
    public AudioClip scary8;

    List<AudioClip> clips;
    AudioSource AS;

    float timer = 12f;
    float counter = 0f;

    // Use this for initialization
    void Start () {
        AS = GetComponent<AudioSource>();
		clips = new List<AudioClip>() { scary1, scary2, scary3, scary4, scary5, scary6, scary7, scary8 };
    }
	
	// Update is called once per frame
	void Update () {
        if (counter > timer) {
            int chance = Random.Range(0, 1);
            if (chance == 1) {
                playRandomScarySound();
                counter = 0f;
            }
        }
        counter += Time.deltaTime;
	}

    public void playRandomScarySound() {
        int randnum = Random.Range(0, clips.Count);
        AS.clip = clips[randnum];
        AS.Play();
    }
}
