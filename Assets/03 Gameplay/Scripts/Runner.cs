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

	public GameObject gaz,liquido, solido;

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

		if(transform.position.y > 1.3)
		{
			gaz.SetActive(true);
			liquido.SetActive(false);
			solido.SetActive(false);
		}
		else if( transform.position.y <= 1.5 && transform.position.y >= -1)
		{
			gaz.SetActive(false);
			liquido.SetActive(true);
			solido.SetActive(false);
		}
		else if( transform.position.y < -1)
		{
			gaz.SetActive(false);
			liquido.SetActive(false);
			solido.SetActive(true);
		}

	}
}
