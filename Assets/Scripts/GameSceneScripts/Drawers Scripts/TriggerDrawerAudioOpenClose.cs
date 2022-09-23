using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDrawerAudioOpenClose : MonoBehaviour
{
    [SerializeField] private AudioSource snd_OpenDrawer;
    [SerializeField] private AudioSource snd_CloseDrawer;

        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Drawer")
        {
            snd_OpenDrawer.Play();
            Debug.Log("OPEN");
        }
    }

    void OnTriggerExit(Collider other)
    {



        if (other.gameObject.tag == "Drawer")
       {
            snd_CloseDrawer.Play();
            Debug.Log("CLOSE");
       }
    }
}
