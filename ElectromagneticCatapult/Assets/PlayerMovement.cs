using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{

	// Use this for initialization
	public float Speed;
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKey(KeyCode.W) == true)
		{
			transform.position += Camera.main.transform.up * Speed;
		}
		else if(Input.GetKey(KeyCode.S) == true)
		{
			transform.position += Camera.main.transform.up * -Speed;
		}
		if(Input.GetKey(KeyCode.A) == true)
		{
			transform.position += Camera.main.transform.right * -Speed;
		}
		else if(Input.GetKey(KeyCode.D) == true)
		{
			transform.position += Camera.main.transform.right * Speed;
		}

	}
}
