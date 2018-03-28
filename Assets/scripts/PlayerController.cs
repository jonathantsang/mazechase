using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed = 6;
    public Transform cameraTransform;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
	{
		//print (Input.GetAxis ("XboxV"));
		//print (Input.GetAxis ("XboxH"));
		float vert = Input.GetAxis ("XboxV");
		float horz = Input.GetAxis ("XboxH");
		// get input data from keyboard or controller
		if (Input.GetKey ("w") || vert == 1) {
			Vector3 position = transform.position;
			position += cameraTransform.forward * speed * Time.deltaTime;
			transform.position = position;
		}
		if (Input.GetKey ("s") || vert == -1) {
			Vector3 position = transform.position;
			position += -cameraTransform.forward * speed * Time.deltaTime;
			transform.position = position;
		}
		if (Input.GetKey ("a") || horz == 1) {
			Vector3 position = transform.position;
			position += -cameraTransform.right * speed * Time.deltaTime;
			transform.position = position;
		}
		if (Input.GetKey ("d") || horz == -1) {
			Vector3 position = transform.position;
			position += cameraTransform.right * speed * Time.deltaTime;
			transform.position = position;
		}
		if (Mathf.Abs(vert) > 0.15 && Mathf.Abs(horz) > 0.15){
			Vector3 position = transform.position;
			Vector3 angle = new Vector3(-horz, 0, vert);
			print (angle);
			position += angle * 3 * speed * Time.deltaTime;
			transform.position = position;
		}
    }
}
