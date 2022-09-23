using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTimer : MonoBehaviour
{
    public Canvas EndGame;
    private int timeLeft = GlobalState.TimeLimit;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitForTimeLimit());
    }

    IEnumerator WaitForTimeLimit()
    {
        while (timeLeft > 0)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
            GlobalState.TimeLeft = timeLeft;
        }

        EndGame.gameObject.SetActive(true);
    }
}
