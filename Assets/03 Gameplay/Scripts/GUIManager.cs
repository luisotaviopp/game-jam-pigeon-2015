using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GUIManager : MonoBehaviour 
{
	
	public Text gameOverText, instructionsText, runnerText, highScore, score;

	string startScoreText;
	string startHighScoreText;

	void Start () 
	{
		GameEventManager.GameStart += GameStart;
		GameEventManager.GameOver += GameOver;
		gameOverText.enabled = false;
		highScore.enabled = false;
		score.enabled = false;

		startScoreText = score.text;
		startHighScoreText = highScore.text;
	}

	void Update () 
	{
		if(Input.anyKeyDown)
		{
			GameEventManager.TriggerGameStart();
		}
	}

	private void GameStart () 
	{
		gameOverText.enabled = false;
		instructionsText.enabled = false;
		runnerText.enabled = false;
		highScore.enabled = false;
		score.enabled = false;
		enabled = false;
	}

	private void GameOver () 
	{
		Debug.Log (Runner.distanceTraveled);
		
		score.text = startScoreText+" "+Runner.distanceTraveled;
		
		if(Runner.distanceTraveled > PlayerPrefs.GetFloat("HighScore"))
		{
			PlayerPrefs.SetFloat("HighScore",Runner.distanceTraveled);
		}
		
		highScore.text = startHighScoreText+" "+PlayerPrefs.GetFloat("HighScore");

		highScore.enabled = true;
		gameOverText.enabled = true;
		instructionsText.enabled = true;
		score.enabled = true;
		enabled = true;
	}
}
