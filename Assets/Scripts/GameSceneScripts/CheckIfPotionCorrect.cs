using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIfPotionCorrect : MonoBehaviour
{
    public BoolVariable PotionIsCorrect;
    public BoolVariable PotionIsDone;
    public GameObject GlassBottle;
    public GameObject[] PowderedIngredients;
    public List<GameObject> SteepingIngredients;
    

    //This script is an "OnTriggerEnter" script
    // It is set on the Water GameObject, which lives in the Apothecary's pan, which is set to Trigger.
    
    // Before the first frame update,
    // I set PotionIsCorrect.value = true and PotionIsDone.value = false;

    // There are only two scenarios that are of interest:
    // 1) PotionIsDone = true  AND PotionIsCorrect = false -> LoadGameOverScene-Lose
    // 2) Both are true -> LoadGameOverScene-Win
    
    // Of course, the potion isn't in a real sense "correct" if it isn't also "done" --
    // In that sense, the value of PotionIsCorrect doesn't matter as long as PotionIsDone hasn't been set
    // PotionIsDone only gets set when the player dips the GlassBottle into the water.
    // At that point, the value of PotionIsCorrect will determine which scene we load when we  wrap up
    // The Ethics Questions sequence.

    // Players might cheat by dipping the bottle into water without ever grinding any ingredients.
    // I need to add a check "if (PowderedIngredients[] = null) then PotionIsDone.value = false; 
    void Start()
    {
        PotionIsDone.value = false;
        PotionIsCorrect.value = true;    
    }

    public void OnTriggerEnter(Collider other)
    {
    
    
    // WHen the Glass Bottle enters the water, checks to see if there are powdered ingredients in the scene
    // If so, set PotionIsDone to true;
    // If not, leave PotionsIsDone as false.
        if (other.tag == "GlassBottle")
        {
            SetPotionDone();   
        }

    // WHen PowderedIngredient collides with Water(Collider)
    // Check whether the tag of the Colliiding object contains term "ingredient"
    // Store the Ingredient gameObject in a list called "Steeping Ingredients"
    // If there's a single INCORRECT powdered ingredient, then set PotionIsCorrect.value = false

        if (other.gameObject.tag.ToString().Contains("Ingredient") == true)
        {
            SteepingIngredients.Add(other.gameObject);
            if (other.tag != "CorrectPowderedIngredient")
            {
                SetPotionIncorrect();
            } 
        }
    }
    

    public void SetPotionDone()
    {        
        if (SteepingIngredients.Count != 0)
        {
            PotionIsDone.value = true;
            Debug.Log("You filled your flask - your potion is done!");
            // When PotionIsDone = true, the Ethics Questions load up.
        } else {
            Debug.Log("You filled your flask, but haven't steeped any ingredients! Your Potion isn't done.");
            //PotionIsDone.value remains false in this case.
        }
    }


    public void SetPotionIncorrect() 
    {
            PotionIsCorrect.value = false;
            Debug.Log("You have steeped a wrong ingredient; your potion is incorrect.");
    }

}
