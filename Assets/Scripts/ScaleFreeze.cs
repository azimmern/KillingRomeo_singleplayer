using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ScaleFreeze : MonoBehaviour
{

    private Rigidbody rb;
    public float thresholdVel = 0.01f;

    void OnTriggerEnter(Collider other)
    {
        rb = other.GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.constraints = RigidbodyConstraints.FreezePositionX;
        }
    }

    void OnTriggerExit(Collider other)
    {
        rb = other.GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.constraints = RigidbodyConstraints.None;
        }
    }
}
