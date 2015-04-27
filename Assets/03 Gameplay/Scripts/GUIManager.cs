using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GUIManager : MonoBehaviour 
{
	
	public GameObject gameOverText, instructionsText, runnerText, highScore, score;

	string startScoreText;
	string startHighScoreText;

	public GameObject panelStop;

	public bool isEscape = false;

	void Start () 
	{
		GameEventManager.GameStart += GameStart;
		GameEventManager.GameOver += GameOver;
		gameOverText.SetActive (false);

		if (highScore != null)
			highScore.SetActive (false);

		if (score != null)
			score.SetActive (false);

		if(score!=null)
			startScoreText = score.GetComponent<Text>().text;

		if(highScore!=null)
			startHighScoreText = highScore.GetComponent<Text>().text;
	}

	void Update () 
	{

		if(Input.GetMouseButtonDown(0))
		{
			if(!isEscape)
			{
				GameEventManager.TriggerGameStart();
			}
		}


		if(Input.GetKeyDown(KeyCode.Escape))
		{
			if(isEscape)
			{
				panelStop.SetActive(true);
				GameEventManager.TriggerPause();
			}
		}
	}

	private void GameStart () 
	{
		gameOverText.SetActive (false); 
		instructionsText.SetActive (false);
		runnerText.SetActive (false);

		if (highScore != null)
			highScore.SetActive (false);
		if (score != null)
			score.SetActive (false);

		isEscape = true;
	}

	private void GameOver () 
	{

		isEscape = false;

		Debug.Log (Runner.distanceTraveled);

		if(score!=null)
			score.GetComponent<Text>().text = startScoreText+" "+Runner.distanceTraveled;
		
		if(Runner.distanceTraveled > PlayerPrefs.GetFloat("HighScore"))
		{
			PlayerPrefs.SetFloat("HighScore",Runner.distanceTraveled);
		}

		if(highScore!=null)
		highScore.GetComponent<Text>().text = startHighScoreText+" "+PlayerPrefs.GetFloat("HighScore");
		if (highScore != null)
			highScore.SetActive (true);

		gameOverText.SetActive (true);
		instructionsText.SetActive (true);

		if (score != null)
			score.SetActive (true);
	}
}
