using UnityEngine;
using System.Collections;

public class BackgroundController : MonoBehaviour 
{
	public GameController game;
	public float maxDistance = 30.0f;

	public Vector3 startPosition;

	void Start () 
	{
		startPosition = transform.position;
		GameEventManager.GameStart += GameStart;
	}

	private void GameStart () 
	{
		transform.position = startPosition;
	}

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
