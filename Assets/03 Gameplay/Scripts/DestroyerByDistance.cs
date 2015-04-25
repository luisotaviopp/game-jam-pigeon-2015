using UnityEngine;
using System.Collections;

public class DestroyerByDistance : MonoBehaviour 
{

	void Update () 
	{
		//		Debug.Log (Runner.distanceTraveled - transform.position.x);
		if(Runner.distanceTraveled - transform.position.x > 30.0f)
		{
			Destroy(gameObject);
		}
	}
}
