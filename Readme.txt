SceneManager
============

Class that allow to load scenes with parameters.

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
