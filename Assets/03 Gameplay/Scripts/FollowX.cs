using UnityEngine;
using System.Collections;

public class FollowX : MonoBehaviour 
{
	public Transform target;

	public float distance = 6;
	
	// Update is called once per frame
	void LateUpdate () 
	{
		Vector3 newPosition = new Vector3(target.position.x + distance,0,-10);
		transform.position = newPosition;
	}
}
