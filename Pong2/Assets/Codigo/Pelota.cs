using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Pelota : MonoBehaviour {

	int fuerza = 65;


	// Use this for initialization
	void Start () {
	//	GetComponent<Rigidbody2D> ().AddForce (transform.up * 250);
		int a = Random.Range (0, 2);
		if (a <= 1) {
			GetComponent<Rigidbody2D> ().AddForce (transform.up * fuerza);
			GetComponent<Rigidbody2D> ().AddForce (transform.right * fuerza);
		} else {
			GetComponent<Rigidbody2D> ().AddForce (-transform.up * fuerza);
			GetComponent<Rigidbody2D> ().AddForce (-transform.right * fuerza);
		}


	}
	// Update is called once per frame
	void Update () {
		
	}
	//Cuando toque las paredes se destruira la bola
	void OnCollisionEnter2D(Collision2D col){
		
		if(col.gameObject.name == "Izquierda"){
			Destroy (this.gameObject);
		}
		
		if(col.gameObject.name == "Derecha"){
			Destroy(this.gameObject);
		
		}
	}

}
