using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour 
{
	public float lenghtBackground = 41.39f;
	float nextBackgroundPosition = 93.79f;

	public GameObject[] blocks;

	public float respawDelay;

	public float forewardRunner = 10.0f;

	float timeRespaw;

	public float getNextBackgroundPosition()
	{
		nextBackgroundPosition += lenghtBackground;
		return nextBackgroundPosition;
	}

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		/*
		timeRespaw += Time.deltaTime; 
		if (respawDelay - timeRespaw < 0) 
		{
			timeRespaw = 0;
			int indicePrefab = Random.Range (0, blocks.Length);
			GameObject instatiate = blocks [indicePrefab];
			Vector3 newPosition = new Vector3(Runner.distanceTraveled+forewardRunner, instatiate.transform.position.y, instatiate.transform.position.z);
			GameObject.Instantiate (instatiate,newPosition,Quaternion.identity);
		}*/
	}
}
