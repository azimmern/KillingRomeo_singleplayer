using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PoisonVisible : MonoBehaviour
{
    //private bool filled;
    // public bool endgame;
    // public UnityEvent showEndgame;

    public BoolVariable IsPotionCorrect;
    public BoolVariable IsPotionDone;
    private int poisonindex;

    void Start()
    {
        //filled = false;
        //endgame = false;
        GetComponent<Renderer>().enabled = false;
        poisonindex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider water)
    {
        if (water.tag == "Water")
        {
            poisonindex = water.GetComponent<ColorLerp>().colorindex;
            Debug.Log(poisonindex);
            GetComponent<Renderer>().enabled = true;
            GetComponent<Renderer>().material = water.GetComponent<Renderer>().material;
            water.gameObject.SetActive(false);

            IsPotionDone.value = true;
            //showEndgame.Invoke();
            if(poisonindex ==3) /// Double check whether ==3 really is the right way to think about poison index
            {
                IsPotionCorrect.value = true;
                //endgame = true;
            }
        }
    }
}
