using UnityEngine;
using System.Collections;

public class AsteroidMovement : MonoBehaviour {

	private const int myMin = -10;
	private const int myMax = 10;
	private const int mySpeed = 3;
	private Vector3 myDirection;

	// Use this for initialization
	void Start () 
	{
		//TODO: make sure it's not 0 on both values
		float x = Random.Range (-1, 1);
		float z = Random.Range (-1, 1);
		myDirection = new Vector3(x, 0, z);
	}
	
	// Update is called once per frame
	void Update () 
	{
		//transform.position += transform.forward * mySpeed * Time.deltaTime;
		transform.position += myDirection * mySpeed * Time.deltaTime;

		if ( transform.position.z > myMax) 
		{
			//transform.position = new Vector3(0,0,0); //.Set(0,0,0);
			Vector3 pos = transform.position;
			pos.z = -5;
			transform.position = pos;
		}

		if ( transform.position.z < myMin) 
		{
			//transform.position = new Vector3(0,0,0); //.Set(0,0,0);
			Vector3 pos = transform.position;
			pos.z = 5;
			transform.position = pos;
		}

		if ( transform.position.y != 0) 
		{
			//transform.position = new Vector3(0,0,0); //.Set(0,0,0);
			Vector3 pos = transform.position;
			pos.y = 0;
			transform.position = pos;
		}


		if ( transform.position.x > myMax) 
		{
			//transform.position = new Vector3(0,0,0); //.Set(0,0,0);
			Vector3 pos = transform.position;
			pos.x = -5;
			transform.position = pos;
		}
		if ( transform.position.x < myMin) 
		{
			//transform.position = new Vector3(0,0,0); //.Set(0,0,0);
			Vector3 pos = transform.position;
			pos.x = 5;
			transform.position = pos;
		}
	
	}
}
