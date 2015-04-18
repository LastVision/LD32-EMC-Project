using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BulletDetonation : MonoBehaviour {

	// Use this for initialization
	public float radius = 1;
	private List<GameObject> affectedGameObjects = new List<GameObject>();

	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void Detonation()
	{
		TargetObjects();
		foreach(GameObject go in affectedGameObjects)
		{
			//go.GetComponents()
		}
	}

	void TargetObjects()
	{
		affectedGameObjects.Clear();
		GameObject[] allGameObjects;
		allGameObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();
		foreach(GameObject go in allGameObjects)
		{
			if(Vector3.Distance(this.transform.position, go.transform.position) < radius && go.activeInHierarchy)
			{
				affectedGameObjects.Add(go);
			}
		}
	}
}
