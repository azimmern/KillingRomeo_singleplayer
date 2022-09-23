using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    // Start is called before the first frame update
    public BoolVariable PotionIsCorrect;
    public BoolVariable PotionIsDone;

    public void LoadGameScene()
    {
        PotionIsCorrect.value = true;
        PotionIsDone.value = false;
        
        SceneManager.LoadScene("Game Scene");
        Debug.Log("Loading Game Scene");
    }


}
