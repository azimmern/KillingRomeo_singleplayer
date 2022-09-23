using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrinderIngredient : StoneGrinder
{
    //public GameObject sample;
    public GameObject grinder;
    public float ingredientPos;
    public float ingredientDrop;
    public int spawnedGrounds;
    int drops;
    
    // Start is called before the first frame update
    void Start()
    {
        ingredientDrop = 0.0005f;
        spawnedGrounds = 0;
        drops = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider item)
        //whenever something enters the collider (set to "trigger") do something
    {
        //Debug.Log("triggered");
        //Debug.Log(item.name);
        
        if (item.tag == "correct_Ingredient")
            //if the gameObject that's interacted with the collider is tagged with "correct_Ingredient"....
        {
            grinder.GetComponent<StoneGrinder>().grinderEmpty = false;
            //tell the grinder that it's no longer empty and that it is ready to grind things up
        } else if (item.tag == "incorrect_Ingredient")
            // if the gameObject interacting with the collider is tagged with "incorrect_Ingredient"... 
        {
            item.attachedRigidbody.AddForce(transform.up * 20f);
            // tell the item's RigidBody to shoot up -- i.e. tell the player, that's not the right ingredient, get that outta here...
        }
        
    }

    public void OnTriggerStay(Collider item)
        //as long as an item stays within the collider (set to "trigger") do something...
    {
        
        if (grinder.GetComponent<StoneGrinder>().spawnCount > spawnedGrounds&&drops<30)
        {
            item.transform.position = new Vector3(item.transform.position.x,item.transform.position.y-ingredientDrop,item.transform.position.z);
            Debug.Log(spawnedGrounds);
             
            spawnedGrounds+=1;
            drops += 1;
           

            
        }
        ingredientPos = item.transform.position.y;
        if(grinder.GetComponent<StoneGrinder>().destroy == true)
            //keep checking to see if the collider should destroy the object that it holds
            //this is a bool within the StoneGrinder script that gets set off if we spawn our maximum allowed prefabs
        {
            Destroy(item.gameObject);
            //destroy the gameobject that's inside the collider
            grinder.GetComponent<StoneGrinder>().destroy = false;
            //turn off the bool that's used to kick off the destruction of the ingredients in the collider


            

        }   
    }


}

