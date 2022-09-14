using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script manages the whole interaction between the player and the UI panels.
//The main component is a GameObject[] array of panels. Each panel contains snippets of Shakespeare's dialogue
//and or ethical questions, which players answer yes or no.
// When Romeo says "Hold, there is forty ducats" (i.e panelIndex = 1),a Coroutine begins to spawn a fortyDucatsPrefab (after 2 second pause)
// When we have run through all of the panels, we check if the potion is correct or incorrect and then LoadScene accordingly
// either to "Game Over - Win" or "Game Over - Lose"
public class PanelsManager : MonoBehaviour
{
    public GameObject[] PanelsArray;
    public int panelIndex;
    public bool panelsOn;
    public GameObject fortyDucatsPrefab;
    private Vector3 spawnPoint = new Vector3(5.75f,0.75f,5.29f);
    private float waitTime = 2f;
    

//Before the game even starts, we turn all of the panels off, set the boolean value panelsOn to false, and set panelIndex to 0
    void Awake()
    {
        foreach (GameObject i in PanelsArray)
        {
            i.SetActive(false);
        }
        panelsOn = false;
        panelIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        //Eventually, we will want to check if the Global static bool weHaveAPotion = true 
        // and if it is, we set the first panel active.
        // That should look something like this:

        // if (weHaveAPotion == true ) -> PanelsArray[panelIndex].SetActive(true);

        //For the moment and for testing, I am using a public boolean "panelsOn" like an on/off switch.
        if (panelsOn == true)
        {
            PanelsArray[panelIndex].SetActive(true);
        }
    }

    public void LoadNextPanel()
    {
        //This function/method must be set as an OnClick() function of every Button
        // in every Panel of the array. Otherwise, this whole sequence fails.
        //Begin by checking that the panelIndex is still within the Array
        if (panelIndex < PanelsArray.Length)
        { 
            //If so, turn the current panel off
            PanelsArray[panelIndex].SetActive(false);
            //Iterate on the index
            panelIndex += 1;
            //Turn the next panel on
            PanelsArray[panelIndex].SetActive(true);
        } else
        {
            //The only way this "else" statement gets called is if we are out of the array,
            // and that means we're done clicking through the panels.
            // So now it's time to check if the potion is correct in the Global Variables script
            //
            Debug.Log("End of Panels; check if potion correct");
            // -- if it is, LoadScene("Game Over - Win"); else, LoadScene("GameOver - Lose");
        }

        //In the Update function, we can also add effects related to specific panels. For instance:
        //IF we're on panel 1, which ends with "Hold, there is forty ducats," 
        //then we can run the coroutine "FortyDucats" which spawns a prefab after a few seconds' pause.
        if (panelIndex == 1)
        {
            Debug.Log("He offers some gold");
            StartCoroutine(FortyDucats(waitTime));
    
        }          
    }

    IEnumerator FortyDucats(float delay)
    {
        Debug.Log("CoRoutine Started");
        yield return new WaitForSeconds(delay);
        Instantiate(fortyDucatsPrefab, spawnPoint, transform.rotation);
        //We can also eventually add an AudioSource here and play a gold clinking sound.
        
    }
}
