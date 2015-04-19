using UnityEngine;
using System.Collections;

public class PlayerWeapon : MonoBehaviour
{
	public GameObject explosionBullet;
	public GameObject implosionBullet;
	public float Speed = 1;
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButtonDown("Fire1") == true) {
			Instantiate (explosionBullet, transform.position, transform.rotation);
		}
		else if (Input.GetButtonUp("Fire1") == true) {
			GameObject bulletMove = GameObject.FindGameObjectWithTag ("ExplosionBullet");
			if (bulletMove) {
				bulletMove.GetComponent<PlayerBulletMovement> ().SetBulletStop(true);
				bulletMove.GetComponent<BulletDetonation> ().Detonation();
			}
		}
		else if (Input.GetButton("Fire1") == true) {
			GameObject bulletMove = GameObject.FindGameObjectWithTag ("ExplosionBullet");
			if (bulletMove) {
				bulletMove.GetComponent<PlayerBulletMovement> ().SetBulletStop(false);
			}
		}
	}
}