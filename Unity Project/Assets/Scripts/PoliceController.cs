using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceController : MonoBehaviour {

	// Use this for initialization
	GameObject Player;
	void Start () {
		Player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if(Player.GetComponent<TruckScript>().score > 40)
        {
        	transform.Translate(0, -12*Time.deltaTime, 0);
		}
		if(transform.position.y < -30 )
		{ Destroy(gameObject);}
	}
	private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
            Destroy(gameObject);
    }
}
