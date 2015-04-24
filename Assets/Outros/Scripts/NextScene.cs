using UnityEngine;
using System.Collections;

public class NextScene : MonoBehaviour 
{
	public void LoadLevel(string sceneName)
	{
		Application.LoadLevel (sceneName);
	}
}
