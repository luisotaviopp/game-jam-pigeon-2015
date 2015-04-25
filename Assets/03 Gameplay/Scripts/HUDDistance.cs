using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUDDistance : MonoBehaviour 
{	
	// Update is called once per frame
	void Update () 
	{
		GetComponent<Text> ().text = Runner.distanceTraveled.ToString();
	}
}
