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





	void Start()
	{
		velocity = startVelocity;
	}

	void Update () 
	{	
		velocity *= scaleVelocity;

		transform.Translate(velocity * Time.deltaTime, 0f, 0f);

		transform.position = new Vector3 (transform.position.x, -1 * limit + (scrollBar.value * 2 * limit) , transform.position.z);

		distanceTraveled = transform.localPosition.x;
	}
}
