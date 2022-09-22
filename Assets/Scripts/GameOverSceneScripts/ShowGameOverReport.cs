using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowGameOverReport : MonoBehaviour
{
    public BoolVariable PotionIsCorrect;
    public BoolVariable DoYouKnowThisClient;
    public BoolVariable DoYouTrustThisClient;
    public BoolVariable DoYouTrustYourPotion;
    public StringVariable HowMuchIs40Ducats;
    public BoolVariable DoYouAcceptPenaltyOfDeath;
    public BoolVariable DoYouBelievePovertyExcusesYou;
    public StringVariable WhatDoesShakespeareSay;


    public GameObject FinalReport;
    public TMP_Text Title;
   //public TMP_Text TimeLeftText;
    public TMP_Text Answer1;
    public TMP_Text Answer2;
    public TMP_Text Answer3;
    public TMP_Text Answer4;
    public TMP_Text Answer5;
    public TMP_Text Answer6;
    public TMP_Text Answer7;
    


    void Awake()
    {
        LoadYesNoAnswers();
        CheckIfCorrectAnswer();
        ShowEndReport();
    }
    
    public void LoadYesNoAnswers()
    {
        if (DoYouKnowThisClient.value == true)
        {
            Answer1.GetComponent<TextMeshProUGUI>().text = "Yes";
        } else {
            Answer1.GetComponent<TextMeshProUGUI>().text = "No";
        }

        if (DoYouTrustThisClient.value == true)
        {
            Answer2.GetComponent<TextMeshProUGUI>().text = "Yes";
        } else {
            Answer2.GetComponent<TextMeshProUGUI>().text = "No";
        }

        if (DoYouTrustYourPotion.value == true)
        {
            Answer3.GetComponent<TextMeshProUGUI>().text = "Yes";
        } else {
            Answer3.GetComponent<TextMeshProUGUI>().text = "No";
        }

        if (DoYouAcceptPenaltyOfDeath.value == true)
        {
            Answer5.GetComponent<TextMeshProUGUI>().text = "Yes";
        } else {
            Answer5.GetComponent<TextMeshProUGUI>().text = "No";
        }

        if (DoYouBelievePovertyExcusesYou.value == true)
        {
            Answer6.GetComponent<TextMeshProUGUI>().text = "Yes";
        } else {
            Answer6.GetComponent<TextMeshProUGUI>().text = "No";
        }
    }

    public void CheckIfCorrectAnswer()
    {
        if (WhatDoesShakespeareSay.value == "My poverty, not my will, consents.")
        {
            Answer7.GetComponent<TextMeshProUGUI>().text = "Correct! The play says: 'My poverty, not my will consents.'";
        } else {
            Answer7.GetComponent<TextMeshProUGUI>().text = "Sorry, Shakespeare did not say: " + WhatDoesShakespeareSay.value + ".";
        }

        if (HowMuchIs40Ducats.value == "$5,953")
        {
            Answer4.GetComponent<TextMeshProUGUI>().text = "Correct! 40 gold ducats is equivalent to $5,953 today.";
        } else {
            Answer4.GetComponent<TextMeshProUGUI>().text = "Sorry, 40 gold ducats is equivalent to $5,953, not " + HowMuchIs40Ducats.value + "." ;
        }
    }

    public void ShowEndReport()
    {
        if(PotionIsCorrect.value == true)
        {
            Title.GetComponent<TextMeshProUGUI>().text = "You got the potion right!";
        } else if (PotionIsCorrect.value == false) 
        {
            Title.GetComponent<TextMeshProUGUI>().text = "You got the potion wrong.";
        }

        FinalReport.SetActive(true);
    }

}
