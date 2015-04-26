using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour 
{
	public float lenghtBackground = 41.39f;
	public float nextBackgroundPosition = 93.79f;
	float startBackgroundPosition;

	public GameObject[] blocks;

	public float[] Layers;

	public float respawDelay;

	public float forewardRunner = 10.0f;

	public Vector3 minRotation, maxRotation;

	public Image fogo,gelo;

	public Scrollbar scrollBar;

	float timeRespaw;

	public float getNextBackgroundPosition()
	{
		nextBackgroundPosition += lenghtBackground;
		return nextBackgroundPosition;
	}

	// Use this for initialization
	void Start () 
	{
		GameEventManager.GameStart += GameStart;
		GameEventManager.GameOver += GameOver;
		enabled = false;
		scrollBar.value = 0.5f;
		startBackgroundPosition = nextBackgroundPosition;
	}

	private void GameStart () 
	{
		nextBackgroundPosition = startBackgroundPosition;

		GameObject[] blocks = GameObject.FindGameObjectsWithTag ("Blocks");
		for(int i=0; i<blocks.Length; i++)
		{
			Destroy(blocks[i]);
		}
		timeRespaw = 0;

		enabled = true;
	}
	
	private void GameOver () 
	{
		enabled = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		fogo.color = new Color (1, 1 - scrollBar.value, 1 - scrollBar.value);
		gelo.color = new Color (scrollBar.value, scrollBar.value, 1); 


		timeRespaw += Time.deltaTime; 
		if (respawDelay - timeRespaw < 0) 
		{
			timeRespaw = 0;
			int indicePrefab = Random.Range (0, blocks.Length);
			GameObject instatiate = blocks [indicePrefab];

			float layer = Layers[Random.Range(0,Layers.Length)];

			Vector3 newPosition = new Vector3(Runner.distanceTraveled+forewardRunner,layer, instatiate.transform.position.z);

			Quaternion rotation = new Quaternion(
				Random.Range(minRotation.x, maxRotation.x),
				Random.Range(minRotation.y,maxRotation.y),
			    Random.Range(minRotation.z,maxRotation.z),0f);

			GameObject.Instantiate (instatiate,newPosition,rotation);
		}
	}
}
