using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadMainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadMainMenuScene()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
