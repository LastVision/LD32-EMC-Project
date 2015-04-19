using UnityEngine;
using System.Collections;

public class PlayerBulletMovement : MonoBehaviour
{
	public float mySpeed;
	private const int myMin = -10;
	private const int myMax = 10;
	private bool bulletStop = false;

	void Start ()
	{
		Vector3 mousePos;
		mousePos.x = Input.mousePosition.x;
		mousePos.y = 0;
		mousePos.z = Input.mousePosition.y;
		Vector3 direction = mousePos - transform.position;
		GetComponent<Rigidbody> ().velocity = direction * mySpeed;
		transform.Rotate (90, 0, 0);
	}

	void Update ()
	{
		if (bulletStop == false) {
			if (transform.position.z > myMax) {
				Destroy (gameObject);
			}
			if (transform.position.z < myMin) {
				Destroy (gameObject);
			}
		
			if (transform.position.y != 0) {
				//transform.position = new Vector3(0,0,0); //.Set(0,0,0);
				Vector3 pos = transform.position;
				pos.y = 0;
				transform.position = pos;
			}
		
		
			if (transform.position.x > myMax) {
				Destroy (gameObject);
			}
			if (transform.position.x < myMin) {
				Destroy (gameObject);
			}
		}
	}

	public void SetBulletStop(bool stopBullet){
		bulletStop = stopBullet;
	}
}
