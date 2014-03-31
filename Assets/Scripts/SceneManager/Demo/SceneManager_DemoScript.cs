using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SceneManager_DemoScript : MonoBehaviour
{
	private string argument="Test";

	void OnGUI()
	{
		GUI.Label(new Rect(Screen.width*0.5f-100, Screen.height*0.5f-60, 200, 20), "Argument:");
		argument=GUI.TextField(new Rect(Screen.width*0.5f-100, Screen.height*0.5f-30, 200, 20), argument);

		if (GUI.Button(new Rect(Screen.width*0.5f-50, Screen.height*0.5f, 100, 20), "Load scene"))
		{
			Dictionary<string, string> arguments=new Dictionary<string, string>();
			arguments["argument"]=argument;
			SceneManager.LoadScene("SceneManager_Demo2", arguments);
		}
	}
}
