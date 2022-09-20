using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGameOver : MonoBehaviour
{
    public BoolVariable PotionIsCorrect;
    public BoolVariable PotionIsDone;
    public void LoadGameOverScene()
    {
        if (PotionIsCorrect.value == true && PotionIsDone.value == true)
        {
            SceneManager.LoadScene("Game Over - Win");
        }

        if (PotionIsCorrect.value == false && PotionIsDone.value == true)
        {
            SceneManager.LoadScene("Game Over - Lose");
        }
    }

}
