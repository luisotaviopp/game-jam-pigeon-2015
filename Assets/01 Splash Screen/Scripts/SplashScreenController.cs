using UnityEngine;
using System.Collections;

public class SplashScreenController : MonoBehaviour 
{
	public float delayMinNextScene = 3.0f;
	public string nextSceneName = "Main Menu";

	IEnumerator Start () 
	{
		//Aproveitar esse tempo para fazer o loading da proxima Cena
		yield return new WaitForSeconds (delayMinNextScene);
		GetComponent<NextScene> ().LoadLevel (nextSceneName);
	}
}
