using UnityEngine;
using System.Collections;

public class EnemyShooting : MonoBehaviour {

	private const int delayBetweenShots = 1;
	private float currentDelay;

	public GameObject Bullet;
	
	void Start () 
	{
		currentDelay = 0;
	}

	void Update () 
	{
		currentDelay += Time.deltaTime;

		if (currentDelay >= delayBetweenShots) 
		{
			currentDelay = 0;
			//Spawninstance
			Quaternion rotateVector = transform.rotation;
			//Vector3 rotatevector = transform.rotation;
			rotateVector.Set(transform.rotation.x, transform.rotation.y,transform.rotation.z, transform.rotation.w);
			//rotateVector.Set(90, 0, 0, 0);
			//rotateVector.Set(0,0,0,0);
			Instantiate(Bullet, transform.position, rotateVector);
		}
	}
}
