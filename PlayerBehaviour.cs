using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {

	public float velocidade;
	private float xMax = 8.5f;
	private float yMax = 4.6f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		 transform.Translate(Vector3.right*Input.GetAxisRaw("Horizontal")*velocidade*Time.deltaTime);
		 transform.Translate(Vector3.up*Input.GetAxisRaw("Vertical")*velocidade*Time.deltaTime);

		if (transform.position.x >= xMax){
			transform.position = new Vector3(-xMax, transform.position.y);	
		} else if (transform.position.x <= -xMax){
			transform.position = new Vector3(xMax, transform.position.y);
		} else if (transform.position.y >= yMax){
		 	  transform.position = new Vector3( transform.position.x, -yMax);
		} else if (transform.position.y <= -yMax){
			  transform.position = new Vector3( transform.position.x, yMax);
		}
		
		//Movimentacao(); 
	}
	void Movimentacao() {

	
	
	if (Input.GetAxisRaw("Horizontal") > 0 ) {
		direita();
	}
	if (Input.GetAxisRaw("Horizontal") < 0 ) {
		esquerda();
	}
	if (Input.GetAxisRaw("Vertical") > 0 ) {
		up();
	}
	if (Input.GetAxisRaw("Vertical") < 0 ) {
		down();
	}



	
 	}
	public void direita(){
		transform.Translate (Vector2.right * velocidade * Time.deltaTime);
		//transform.localScale = new Vector2(1, 1);
	}
	public void esquerda(){
		transform.Translate (-Vector2.right * velocidade * Time.deltaTime);
		//transform.localScale = new Vector2(-1, 1);
	}
	public void up(){
		transform.Translate (Vector3.up * velocidade * Time.deltaTime);
	}
	public void down (){
		transform.Translate (-Vector3.up * velocidade * Time.deltaTime);
	}
}
