using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

	private Transform target;

	const short moveSpeed = 3;
	const short rotationSpeed = 3;


	// Init
	void Start () 
	{
		target = GameObject.FindWithTag("Player").transform;
	
	}
	
	// Update 
	void Update () 
	{
		transform.position += transform.forward * moveSpeed * Time.deltaTime;
		transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.position - transform.position), rotationSpeed*Time.deltaTime);
	}
	
}