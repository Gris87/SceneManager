using UnityEngine;
using System.Collections;

public class SceneManager_DemoScript : MonoBehaviour
{
    private string argument="Test";

    void OnGUI()
    {
        GUI.Label(new Rect(Screen.width*0.5f-100, Screen.height-90, 200, 20), "Argument:");
        argument=GUI.TextField(new Rect(Screen.width*0.5f-100, Screen.height-60, 200, 20), argument);

        if (GUI.Button(new Rect(Screen.width*0.5f-50, Screen.height-30, 100, 20), "Load scene"))
        {
            Hashtable arguments=new Hashtable();
            arguments.Add("argument", argument);
            SceneManager.LoadScene("SceneManager_Demo2", arguments);
        }
    }
}
