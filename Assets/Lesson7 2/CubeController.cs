using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {
	 

	private float speed = -0.2f;
	private float DeadLine = -10;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (this.speed, 0,0);
		if (transform.position.x < this.DeadLine) {
			Destroy (this.gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D Col){
		if (Col.gameObject.tag == "CubeTag"||Col.gameObject.tag == "GroundTag") {
			GetComponent<AudioSource> ().Play ();
		}
	}
}
