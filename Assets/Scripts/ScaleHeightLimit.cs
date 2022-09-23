using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleHeightLimit : MonoBehaviour
{
    public Transform limit;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= limit.position.y)
        {
            transform.position = new Vector3(transform.position.x, limit.position.y, transform.position.z);
        }
    }
}
