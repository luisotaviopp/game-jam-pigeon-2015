using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour 
{
	public float lenghtBackground = 40.0f;
	float nextBackgroundPosition = 45.0f;

	public float getNextBackgroundPosition()
	{
		nextBackgroundPosition += lenghtBackground;
		return nextBackgroundPosition;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
