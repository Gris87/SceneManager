using UnityEngine;
using System.Collections;

public class SceneManager_DemoScript2 : MonoBehaviour
{
	private string argument;

	// Use this for initialization
	void Start()
	{
		argument=SceneManager.sceneArguments["argument"];
	}

	void OnGUI()
	{
		GUI.Label(new Rect(Screen.width*0.5f-100, Screen.height*0.5f-30, 200, 20), "Argument:");
		GUI.Label(new Rect(Screen.width*0.5f-100, Screen.height*0.5f, 200, 20), argument);
	}
}
