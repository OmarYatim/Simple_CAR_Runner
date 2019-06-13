using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CArMovement : MonoBehaviour {

    GameObject Car;
    float speed;
	// Use this for initialization
	void Start () {
        Car = GameObject.FindGameObjectWithTag("Player");
		speed = 4;
	}
	
	// Update is called once per frame
	void Update () {
        if(Car.GetComponent<CarScript>().score > 20)
        {
            speed = 8;
        }
        transform.Translate(0, -speed*Time.deltaTime, 0);
        if(transform.position.y < -7)
        {
            Destroy(gameObject);
        }
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
            Destroy(gameObject);
    }
}
