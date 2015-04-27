using UnityEngine;
using System.Collections;

public class SplashScreenController : MonoBehaviour 
{
    public GameObject[] logo;
    public float logoTime = 2;
    float counter = 0;
    int logoIndex = 0;
	public string nextLevel = "Esgoto";
    // Update is called once per frame

    void Start()
    {
        for (int i = 0; i < logo.Length; i++)
        {
            ShowHide(i, false);
        }
        ShowHide(0, true);
    }

    void Update()
    {
        counter += Time.deltaTime;
        if (counter > logoTime)
        {
            logoIndex++;
            if (logoIndex > logo.Length - 1)
            {
                Application.LoadLevel(nextLevel);
                return;
            }
            ShowHide(logoIndex-1, false);
            ShowHide(logoIndex, true);
            counter = 0;
        }
    }


    void ShowHide(int index, bool state)
    {
        logo[index].SetActive(state);
    }
    
    
    
    /*
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
     * */
}
