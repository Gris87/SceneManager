using UnityEngine;
using System.Collections;

public class SceneManager_DemoScript2 : MonoBehaviour
{
	private string argument;

	// Use this for initialization
	void Start()
	{
		argument=(string)SceneManager.sceneArguments["argument"];
	}

	void OnGUI()
	{
		GUI.Label(new Rect(Screen.width*0.5f-100, Screen.height-90, 200, 20), "Argument:");
		GUI.Label(new Rect(Screen.width*0.5f-100, Screen.height-60, 200, 20), argument);

		if (GUI.Button(new Rect(Screen.width*0.5f-50, Screen.height-30, 100, 20), "Back"))
		{
			SceneManager.LoadScene("SceneManager_Demo");
		}
	}
}
