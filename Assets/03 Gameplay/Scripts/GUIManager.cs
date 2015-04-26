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

		if(highScore!=null)
		highScore.enabled = false;

		if(score!=null)
		score.enabled = false;

		if(score!=null)
		startScoreText = score.text;

		if(highScore!=null)
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

		if(highScore!=null)
		highScore.enabled = false;
		if(score!=null)
		score.enabled = false;

		enabled = false;
	}

	private void GameOver () 
	{
		Debug.Log (Runner.distanceTraveled);

		if(score!=null)
		score.text = startScoreText+" "+Runner.distanceTraveled;
		
		if(Runner.distanceTraveled > PlayerPrefs.GetFloat("HighScore"))
		{
			PlayerPrefs.SetFloat("HighScore",Runner.distanceTraveled);
		}

		if(highScore!=null)
		highScore.text = startHighScoreText+" "+PlayerPrefs.GetFloat("HighScore");
		if(highScore!=null)
		highScore.enabled = true;

		gameOverText.enabled = true;
		instructionsText.enabled = true;

		if(score!=null)
		score.enabled = true;

		enabled = true;
	}
}
