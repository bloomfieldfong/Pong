using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jugadores : MonoBehaviour {
	
	Vector2 porteria;
	public int player;
	float   factorVel;
	bool x; 

	
	// Use this for initialization
	void Start () {
		porteria = new Vector2(0.0f,0.0f);
		factorVel = 10.0f;

	}
	
	// Update is called once per frame
	void Update () {
		
		porteria.y = 0.0f;
	
		if (player ==1){		
			if (Input.GetKey(KeyCode.UpArrow) ){
				porteria.y = factorVel * Time.deltaTime;
				transform.Translate(porteria);	
			}
			
			if (Input.GetKey(KeyCode.DownArrow) ){
				porteria.y = -factorVel * Time.deltaTime;
				transform.Translate( porteria);	
			}
				
		}
		
		if (player == 2){		
			if (Input.GetKey(KeyCode.W) ){
				porteria.y = factorVel * Time.deltaTime;
				transform.Translate( porteria);	
			}
			
			if (Input.GetKey(KeyCode.S) ){
				porteria.y = -factorVel * Time.deltaTime;
				transform.Translate(porteria);	
			}
			
		}

		if (Input.GetKey (KeyCode.R)) {
			SceneManager.LoadScene (0); 
		}
		
	}
}
