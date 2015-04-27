using UnityEngine;
using System.Collections;

public class NextScene : MonoBehaviour 
{

	public void NameScene(string nameScene)
	{
		Application.LoadLevel (nameScene);
	}
}
