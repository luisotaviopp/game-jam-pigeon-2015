using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Runner : MonoBehaviour 
{
	public Scrollbar scrollBar;
	public static float distanceTraveled;
	public float limit = 4.6f;

	public float startVelocity = 5f;
	public float scaleVelocity = 1.001f;
	public float velocity;

	public float velocityYScale = 10f;

	void Start()
	{
		velocity = startVelocity;
	}

	void Update () 
	{	
		velocity *= scaleVelocity;

		float yDestino = -1 * limit + (scrollBar.value * 2 * limit);

		//Debug.Log (yDestino);

		float yDiference = yDestino - transform.position.y;

		//Debug.Log ("Diference: " + yDiference);

		transform.Translate(velocity * Time.deltaTime, yDiference*Time.deltaTime, 0f);

		distanceTraveled = transform.localPosition.x;
	}
}
