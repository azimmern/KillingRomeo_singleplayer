using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGameOver : MonoBehaviour
{
    public void LoadGameOverWinScene()
    {
        SceneManager.LoadScene("Game Over - Win");
    }

    public void LoadGameOverLoseScene()
    {
        SceneManager.LoadScene("Game Over - Lose");
    }
}
