using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // public static int sceneCountInBuildSettings; 
    // can create scenes in your scripts

    public void nextbutton()
    {
        SceneManager.LoadScene("Scene2", LoadSceneMode.Single);  // can also use index of scene or path
        Debug.Log("scene 2 of " + SceneManager.sceneCountInBuildSettings + " scenes");
    }

    public void prevbutton()
    {
        SceneManager.LoadScene("Scene1", LoadSceneMode.Single);
        Debug.Log("scene 1 of " + SceneManager.sceneCountInBuildSettings + " scenes");
    }

    public void both()
    {
        if (SceneManager.GetActiveScene().name == "Scene1")
        {
            SceneManager.LoadScene("Scene2", LoadSceneMode.Additive);
        }
        else
        {
            SceneManager.LoadScene("Scene1", LoadSceneMode.Additive);
        }
    }
    // can reload in single mode to get rid of the extra scene
}
