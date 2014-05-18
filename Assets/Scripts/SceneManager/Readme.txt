SceneManager
============

Class that allow to load scenes with parameters.

Demo:    http://gris.ucoz.ru/UnityModules/SceneManager/Web/SceneManager.html
Sources: http://gris.ucoz.ru/UnityModules/SceneManager/SceneManager.zip

Description:

You have to use commands below to load scene with parameters:



Hashtable arguments=new Hashtable();

arguments.Add("StringParam",  "Test");
arguments.Add("IntParam",     123);
arguments.Add("FloatParam",   0.5f);
arguments.Add("DoubleParam",  0.1648);
arguments.Add("BooleanParam", true);

SceneManager.LoadScene("AnotherScene", arguments);


Use commands below in another scene script:


void Start()
{
    Debug.Log((string)SceneManager.sceneArguments["StringParam"]);
    Debug.Log((int)   SceneManager.sceneArguments["IntParam"]);
    Debug.Log((float) SceneManager.sceneArguments["FloatParam"]);
    Debug.Log((double)SceneManager.sceneArguments["DoubleParam"]);
    Debug.Log((bool)  SceneManager.sceneArguments["BooleanParam"]);
}



Links:

Site:    http://gris.ucoz.ru/index/scenemanager/0-10
Sources: http://gris.ucoz.ru/UnityModules/SceneManager/SceneManager.zip
GitHub:  https://github.com/Gris87/SceneManager
