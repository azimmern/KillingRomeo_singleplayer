using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RecordAnswer : MonoBehaviour
{
    public GameObject PanelsManager;
    public BoolVariable DoYouKnowThisClient;
    public BoolVariable DoYouTrustThisClient;
    public BoolVariable DoYouTrustYourPotion;
    public StringVariable HowMuchIs40Ducats;
    public BoolVariable DoYouAcceptPenaltyOfDeath;
    public BoolVariable DoYouBelievePovertyExcusesYou;
    public StringVariable WhatDoesShakespeareSay;
    // 

    public void StoreYesAnswer()
    {
        int panelCount = PanelsManager.GetComponent<PanelsManager>().panelIndex + 1; //adding 1 to index to reflect panel number in hierarchy
        if (panelCount == 6)
        {
            DoYouKnowThisClient.value = true;
            Debug.Log("Do you know client:" + DoYouKnowThisClient.value);
        }

        if (panelCount == 7)
        {
            DoYouTrustThisClient.value = true;
            Debug.Log("Do you trust client:" + DoYouTrustThisClient.value);            
        }
 
        if (panelCount == 8)
        {
            DoYouTrustYourPotion.value = true;
            Debug.Log("Do you trust potion:" + DoYouTrustYourPotion.value);    
        }

        if (panelCount == 10)
        {
            DoYouAcceptPenaltyOfDeath.value = true;
            Debug.Log("Do you accept death:" + DoYouAcceptPenaltyOfDeath.value);    
        }

        if (panelCount == 11)
        {
            DoYouBelievePovertyExcusesYou.value = true;
            Debug.Log("Does poverty excuse you:" + DoYouBelievePovertyExcusesYou.value);    
        }
    }

    public void StoreNoAnswer()
    {
        int panelCount = PanelsManager.GetComponent<PanelsManager>().panelIndex; //adding 1 to index to reflect panel number in hierarchy
        if (panelCount == 6)
        {
            DoYouKnowThisClient.value = false;
            Debug.Log("Do you know client:" + DoYouKnowThisClient.value);
        }

        if (panelCount == 7)
        {
            DoYouTrustThisClient.value = false;
            Debug.Log("Do you trust client:" + DoYouTrustThisClient.value);   
        }
 
        if (panelCount == 8)
        {
            DoYouTrustYourPotion.value = false;
            Debug.Log("Do you trust potion:" + DoYouTrustYourPotion.value); 
        }

        if (panelCount == 10)
        {
            DoYouAcceptPenaltyOfDeath.value = false;
            Debug.Log("Do you accept death:" + DoYouAcceptPenaltyOfDeath.value);
        }

        if (panelCount == 11)
        {
            DoYouBelievePovertyExcusesYou.value = false;
            Debug.Log("Does poverty excuse you:" + DoYouBelievePovertyExcusesYou.value);
        }
    }

    public void StoreStringAnswer()
    {
        int panelCount = PanelsManager.GetComponent<PanelsManager>().panelIndex + 1; //adding 1 to index to reflect panel number in hierarchy
        
        if (panelCount == 9)
        {
            HowMuchIs40Ducats.value = GetComponentInChildren<TextMeshProUGUI>().text as string;
            Debug.Log("40 Ducats = " + HowMuchIs40Ducats.value);
        }

        if (panelCount == 12)
        {
            WhatDoesShakespeareSay.value = GetComponentInChildren<TextMeshProUGUI>().text as string;
            Debug.Log("Shakespeare says: " + WhatDoesShakespeareSay.value);
        }
    }



}
