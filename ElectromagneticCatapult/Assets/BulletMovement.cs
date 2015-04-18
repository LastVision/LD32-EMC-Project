using UnityEngine;
using System.Collections;

public class BulletMovement : MonoBehaviour {

	public float mySpeed;
	public GameObject myPlayer;
	private const int myMin = -10;
	private const int myMax = 10;

	void Start () 
	{
		Vector3 direction = myPlayer.GetComponent<Transform>().position - transform.position;

		//Normaldirection is weird
		//Vector3 normalDirection = direction.normalized;
		//direction.Set(normalDirection.x, 0, normalDirection.z);

		GetComponent<Rigidbody>().velocity = direction * mySpeed;
		transform.Rotate(90, 0, 0);
	}

	void Update()
	{
		if ( transform.position.z > myMax) 
		{
			Destroy(gameObject);
		}
		if ( transform.position.z < myMin) 
		{
			Destroy(gameObject);
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
			Destroy(gameObject);
		}
		if ( transform.position.x < myMin) 
		{
			Destroy(gameObject);
		}
	}
}
