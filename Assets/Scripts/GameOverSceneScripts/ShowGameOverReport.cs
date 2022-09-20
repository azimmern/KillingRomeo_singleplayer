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
   //public TMP_Text TimeLeftText;
    public TMP_Text PotionStatusText;
    public TMP_Text AnswerText;

    void Awake()
    {
        ShowEndReport();
    }
    
    public void ShowEndReport()
    {
        // int minLeft = GlobalState.TimeLeft / 60;
        // int secLeft = GlobalState.TimeLeft % 60;
    }

}
