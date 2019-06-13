using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_Spawner : MonoBehaviour {

	// Use this for initialization

	[SerializeField]
	GameObject Road;
	GameObject BG;
	void Start () {
		
	}
	// Update is called once per frame
	void Update () {
		
	}
	private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "BG")
        {
           BG = Instantiate(Road,new Vector3(3.476563f,8.25f,0),Quaternion.identity);
        }  
    }
}
