using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowEndReport : MonoBehaviour
{
    public GameObject FinalReport;
    public TMP_Text TimeLeftText;
    public TMP_Text PotionStatusText;
    public TMP_Text AnswerText;
    
    public void RevealEndReport(string answer)
    {
        FinalReport.SetActive(true);
        int minLeft = GlobalState.TimeLeft / 60;
        int secLeft = GlobalState.TimeLeft % 60;

        AnswerText.text = answer;
        TimeLeftText.text = minLeft.ToString() + ":" + secLeft.ToString();
        PotionStatusText.text = GlobalState.PotionCorrect ? "Correct" : "Incorrect";
    }
}
