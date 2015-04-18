using UnityEngine;
using System.Collections;

public class EnemyCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Rotate (new Vector2 (15, 15) * Time.deltaTime);
	


	}

	void OnTriggerEnter(Collider other)
	{
		transform.Rotate (new Vector2 (15, 15) * Time.deltaTime);
		if (other.gameObject.tag == "Enemy") 
		{
			other.gameObject.SetActive(false);
		}
	}

}
