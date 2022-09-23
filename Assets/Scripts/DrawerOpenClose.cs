using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerOpenClose : MonoBehaviour

{
    public float openCloseRangeX = .3f;
    public float speed = 10f;
    public float openingRange = 5f;
    private int i = 0;
    
    // Start is called before the first frame update
    void Start() 
    {

    }
   

    // Update is called once per frame
    void Update()
    {

    //boundary box
    // if (transform.position.x <= 0.047f) 
    //     {
    //         transform.position = new Vector3 (0.047f, transform.position.y, transform.position.z);        
    //     }

    // if (transform.position.x > openCloseRangeX)
    //     {
    //         transform.position = new Vector3(openCloseRangeX, transform.position.y, transform.position.z);
        // }

     //movement

        // horizontalInput = Input.GetAxis("Horizontal");
        // transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        
    
    //make a counter
        

        if (Input.GetKeyDown(KeyCode.Space)){
            if ( i % 2 == 1) {
            transform.Translate(Vector3.right * openingRange * speed);
            i++;
            } 
        //close on C
            else {
            transform.Translate(Vector3.right * -openingRange * speed);
            //transform.position = new Vector3(-openCloseRangeX, transform.position.y, transform.position.z);
            i++;
            }
        
        Debug.Log(transform.position);
        }
    }
}
