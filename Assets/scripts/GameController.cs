using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public int collected;

	// Use this for initialization
	void Start () {
		collected = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void addPoint(){
		collected++;
		if(collected == 5){
			print("end of game");
			SceneManager.LoadScene ("win");
		}
	}
}
