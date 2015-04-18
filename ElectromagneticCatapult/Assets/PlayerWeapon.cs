using UnityEngine;
using System.Collections;

public class PlayerWeapon : MonoBehaviour 
{
	public GameObject explosionBullet;
	public GameObject implosionBullet;

	public float Speed = 1;

	private GameObject currentExpBullet;
	private GameObject currentImpBullet;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyUp(KeyCode.Space) == true)
		{
			if(currentExpBullet)
			{
				BulletDetonation bullet = currentExpBullet.GetComponent<BulletDetonation>();
				bullet.Detonation();
			}
		}
		if(Input.GetKeyDown(KeyCode.Space) == true)
		{
			currentExpBullet = Instantiate(explosionBullet);
			currentExpBullet.transform.position = transform.position;
			currentExpBullet.transform.rotation = transform.rotation;
		}
		if(Input.GetKey(KeyCode.Space) == true)
		{
			currentExpBullet.transform.position += Input.mousePosition * Speed;
		}
	}
}
