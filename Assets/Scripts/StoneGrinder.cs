using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneGrinder : MonoBehaviour
{
    [SerializeField]
    public bool grinderEmpty;
    public string grinderSetting;
    public bool destroy;
    public string active;
    public float currentRotate;
    public float previousRotate;
    public Transform[] spawnLocations;
    public GameObject[] LgGrounds;
    public GameObject[] MdGrounds;
    public GameObject[] SmGrounds;
    public GameObject sampleSource;
    float rotateSpeed;
    int spawnMax;
    public int spawnCount;
    

    // Start is called before the first frame update
    void Start()
    {
        rotateSpeed = .01f; 
        spawnMax = 30;
        active = "no";
        grinderEmpty = true;
        previousRotate = 0.0f;
        spawnCount = 0;
        destroy = false;
        
    }

    // Update is called once per frame
    void Update()
    {

        currentRotate = gameObject.transform.rotation.y;
        //establishes a float value of the rotation along the y axis.
        
        if (grinderEmpty == false)
            //checks to make sure there's something submitted to the grinder
        {
            
            float difference = Mathf.Abs(currentRotate - previousRotate);
            //establishes a float value that's the difference between the currentRotation (this frame) and the previousRotation (established as 0.0f on start)
            if (Mathf.Abs(difference) > rotateSpeed)
                //if the difference of the two rotation points are larger than the rotateSpeed float value then do something.
            {
                if (spawnCount <= spawnMax)
                    //spawnCount set to 0 (we haven't made anything yet) on start. 
                {
                    Debug.Log("grinding");
                    //Debug.Log(spawnCount);

                    SpawnGrounds();
                    //call the spawnGround function this frame
                    
                    //lower the gameobject that's in the GrinderIngredient collider (set to "trigger") each time

                    spawnCount++;
                    //iterate the spawn count up to track that we're making something.
                }

                if (spawnCount > spawnMax)
                    //if we've made the amount that we've set as a limit
                {
                    destroy = true; 
                    //change the destroy bool (which triggers off a function in the GrinderIngredient script)
                    grinderEmpty = true;
                    //reset the grinderEmpty bool to true so that we eliminate our opportunity to keep spawning items
                    spawnCount = 0;
                    //reseet the spawnCount back down to 0 so we can track the spawnCount for the next ingredient.
                    sampleSource.GetComponent<GrinderIngredient>().spawnedGrounds = 0;
                    
                    
                }
                
                
                
            }
           
        }
        previousRotate = currentRotate;
        //take currentRotate float value and assign it as the previousRotate float value. This way when the next frame tracks the rotation on the grinder we know if it's moved from previous frame
    }

    void SpawnGrounds()
    {
        int groundi = Random.Range(0, LgGrounds.Length);
        //establish a random integer of the "ground ingredients"

        int locationj = Random.Range(0, spawnLocations.Length);
        //establish a random integer of the spawn locations set around the perimeter of the stone.

        Vector3 spawnSource = new Vector3();
        //create a new (undefined) instance of a Vector3(think "location") attribute.

        spawnSource = spawnLocations[locationj].transform.position;
        //place that newly created Vector3 at a random location found in the 12 spawn locations array


        
        if(grinderSetting == "Large")
        {
            Instantiate(LgGrounds[groundi], spawnSource, Quaternion.identity);
            //instantiate a random prefab object from the LG grounds array at the location established in the spawnSource vector3 (think "location")
        }
        else if(grinderSetting == "Medium")
        {
            Instantiate(MdGrounds[groundi], spawnSource, Quaternion.identity);
            //instantiate a random prefab object from the LG grounds array at the location established in the spawnSource vector3 (think "location")
        }
        else if(grinderSetting == "Small")
        {
            Instantiate(SmGrounds[groundi], spawnSource, Quaternion.identity);
            //instantiate a random prefab object from the LG grounds array at the location established in the spawnSource vector3 (think "location")
        }
    }
}
