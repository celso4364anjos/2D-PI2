using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balistica : MonoBehaviour {
		
			
		public GameObject boca;
		public GameObject layser;
		private float nextfire;
		public float fireRate;
		public GameObject asteroid;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			if (Time.time > nextfire)
			{ 
				nextfire = fireRate + Time.time;
				Instantiate(layser,boca.GetComponent<Transform>().position,Quaternion.identity) ;
			}
			

		}

	}
	  void OnTriggerEnter(Collider asteroid) {
		Destroy(asteroid.gameObject);
	}
}
