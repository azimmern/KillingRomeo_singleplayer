using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorLerp : MonoBehaviour
{
    MeshRenderer waterRender;
    [SerializeField][Range(0f,1f)] float lerpTime;
    [SerializeField] Color[] myColor;
    public int colorindex = 0;
    float t = 0f;
    int len;

    //public bool steeping;

    // Start is called before the first frame update
    void Start()
    {
        //steeping = false;
        waterRender = GetComponent<MeshRenderer>();
        len = myColor.Length;
    }

    // Update is called once per frame
    void Update()
    {


        if (GetComponent<BoilIngredients>().steeping == true)
        {
            waterRender.material.color = Color.Lerp(waterRender.material.color, myColor[colorindex], lerpTime * Time.deltaTime);
            t = Mathf.Lerp(t, 1f, lerpTime * Time.deltaTime);
            if (t > .9f)
            {
                t = 0f;
                colorindex++;
                colorindex = (colorindex >= len) ? 0 : colorindex;
            }
        }
        
      

    }
}
