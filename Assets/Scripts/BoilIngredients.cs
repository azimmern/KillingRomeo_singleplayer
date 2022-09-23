using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoilIngredients : MonoBehaviour
{
    // Start is called before the first frame update
    public bool steeping;
    public BoolVariable PotionIsCorrect;
    void Start()
    {
        steeping = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Bottle")
        {
            steeping = false;
        }
        else if (other.tag == "GroundPowder") // if it's a correct or incorrect powdered ingredient doesn't matter to this function.
        {
            Destroy(other.gameObject);
            steeping = true;
        }
        else if (other.tag != "GroundPowder")
        {
            other.attachedRigidbody.AddForce(transform.up * 20f);
            PotionIsCorrect.value = false;
        }
    }
}
