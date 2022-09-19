using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadTutorial : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadTutorialScene()
    {
        SceneManager.LoadScene("Tutorial Scene");
        Debug.Log("Loading Tutorial Scene");
    }
}
