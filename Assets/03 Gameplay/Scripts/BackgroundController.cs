using UnityEngine;
using System.Collections;

public class BackgroundController : MonoBehaviour 
{
	public GameController game;
	public float maxDistance = 30.0f;

	// Update is called once per frame
	void Update () 
	{
//		Debug.Log (Runner.distanceTraveled - transform.position.x);
		if(Runner.distanceTraveled - transform.position.x > maxDistance)
		{
			Vector3 newPosition = new Vector3(game.getNextBackgroundPosition(),transform.position.y,transform.position.z);
			transform.position = newPosition;
		}
	}
}
