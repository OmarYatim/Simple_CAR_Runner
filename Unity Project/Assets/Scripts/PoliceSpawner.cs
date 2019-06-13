using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceSpawner : MonoBehaviour {

	[SerializeField]
	Sprite Ambulance; 
	[SerializeField]
	GameObject PoliceCruiser;
	GameObject Cops;
	float[] positions;
	bool Police = false;
	// Use this for initialization
	void Start () {
		positions = new float[] { -4, -1.25f, 1.15f, 3.8f };
		Cops = Instantiate(PoliceCruiser, new Vector3(positions[Mathf.RoundToInt(Random.Range(0, 4))], 6.4f, 0), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {

	}

	private void OnCollisionEnter2D(Collision2D other) {
		if(other.collider.tag == "Cruiser")
		{
			//Destroy(other.gameobject);
			Cops = Instantiate(PoliceCruiser, new Vector3(positions[Mathf.RoundToInt(Random.Range(0, 4))], 6.4f, 0), Quaternion.identity);
			Police  =!Police;
			if(Police)
			{Cops.GetComponent<SpriteRenderer>().sprite = Ambulance;}
		}
	}
}
