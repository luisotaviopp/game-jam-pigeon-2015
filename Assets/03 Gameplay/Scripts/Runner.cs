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

	private Vector3 startPosition;

	public AudioClip gameOverClip;

	public AudioClip switchGaz;

	enum estados {gaz,liquido,solido};

	estados estado = estados.liquido;
	
	void Start () 
	{
		GameEventManager.GameStart += GameStart;
		GameEventManager.GameOver += GameOver;
		startPosition = transform.localPosition;
		liquido.SetActive(false);
		enabled = false;
	}
	
	private void GameStart () 
	{
		velocity = startVelocity;
		distanceTraveled = 0f;
		transform.localPosition = startPosition;
		liquido.SetActive(true);
		enabled = true;
	}
	
	private void GameOver () 
	{
		gaz.SetActive (false);
		liquido.SetActive (false);
		solido.SetActive (false);
		enabled = false;
	}

	void OnCollisionEnter(Collision collision) 
	{
		if(collision.gameObject.tag == "Blocks")
		{
			GameEventManager.TriggerGameOver();

			GetComponent<AudioSource>().PlayOneShot(collision.gameObject.GetComponent<BlockController>().effect);

			GetComponent<AudioSource>().PlayOneShot(gameOverClip);
		}
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

		if(transform.position.y > 1.3 && estado != estados.gaz)
		{
			estado = estados.gaz;
			GetComponent<AudioSource>().PlayOneShot(switchGaz);
			gaz.SetActive(true);
			liquido.SetActive(false);
			solido.SetActive(false);
		}
		else if( transform.position.y <= 1.5 && transform.position.y >= -1 && estado != estados.liquido)
		{
			estado = estados.liquido;
			gaz.SetActive(false);
			liquido.SetActive(true);
			solido.SetActive(false);
		}
		else if( transform.position.y < -1 && estado != estados.solido)
		{
			estado = estados.solido;
			gaz.SetActive(false);
			liquido.SetActive(false);
			solido.SetActive(true);
		}
	}




}
