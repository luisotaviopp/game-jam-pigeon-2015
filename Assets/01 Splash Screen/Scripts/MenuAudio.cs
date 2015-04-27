using UnityEngine;
using System.Collections;

public class MenuAudio : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if (FindObjectsOfType<MenuAudio>().Length > 1)
        {
            DestroyImmediate(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
	}

    void LateUpdate(){
        if (Application.loadedLevelName == "Gameplay")
            DestroyImmediate(gameObject);
    }
}
