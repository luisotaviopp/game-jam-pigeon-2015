using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Runner : MonoBehaviour 
{
	public Scrollbar scrollBar;
	public float limit = 4.6f;
	public float velocity = 5f;

	public static float distanceTraveled;

	void Update () 
	{	
		transform.Translate(velocity * Time.deltaTime, 0f, 0f);

		transform.position = new Vector3 (transform.position.x, -1 * limit + (scrollBar.value * 2 * limit) , transform.position.z);

		distanceTraveled = transform.localPosition.x;
	}
}
