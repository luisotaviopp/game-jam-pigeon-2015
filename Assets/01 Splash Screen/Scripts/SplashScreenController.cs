using UnityEngine;
using System.Collections;

public class SplashScreenController : MonoBehaviour 
{
	public float delayMinNextScene = 3.0f;
	public string nextSceneName = "Main Menu";

	void Start () 
	{
		AsyncOperation status = Application.LoadLevelAsync (nextSceneName);

		status.allowSceneActivation = false;
		
		StartCoroutine (LoadLevelProgress (status));
	}
	
	
	IEnumerator LoadLevelProgress (AsyncOperation status) 
	{
		while (!status.isDone && status.progress < 0.9f)
		{
			//Debug.Log ("Loading " + status.progress);

			yield return null;
		}

		float whaitTime = delayMinNextScene - Time.time;
		
		//Debug.Log ("Whait Time: "+whaitTime);
		
		yield return new WaitForSeconds (whaitTime);

		//Debug.Log ("Loading complete");

		status.allowSceneActivation = true;
	}
}
