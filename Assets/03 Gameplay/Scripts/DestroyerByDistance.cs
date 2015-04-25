using UnityEngine;
using System.Collections;

public class DestroyerByDistance : MonoBehaviour 
{
	public float maxDistance = 30.0f;

	void Update () 
	{
		//		Debug.Log (Runner.distanceTraveled - transform.position.x);
		if(Runner.distanceTraveled - transform.position.x > maxDistance)
		{
			Destroy(gameObject);
		}
	}
}
