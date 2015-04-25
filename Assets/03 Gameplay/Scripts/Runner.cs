using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Runner : MonoBehaviour 
{
	public Scrollbar scrollBar;
	public float limit = 4.6f;

	void Update () 
	{
		Debug.Log (scrollBar.value);
	
		transform.Translate(5f * Time.deltaTime, 0f, 0f);

		transform.position = new Vector3 (transform.position.x, -1 * limit + (scrollBar.value * 2 * limit) , transform.position.z);
	}
}
