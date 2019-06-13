using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_Controller : MonoBehaviour {

	public float speed;
	GameObject Car;
	// Use this for initialization
	void Start () {
        Car = GameObject.FindGameObjectWithTag("Player");
		speed = 1;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0,-speed*Time.deltaTime,0);
		if(Car.GetComponent<CarScript>().score > 20)
		{
			speed = 4;
		}
		if(transform.position.y < -12)
		{
			Destroy(gameObject);
		}
	}
}
