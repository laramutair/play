using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public float deg=0f;
    public float angleInc=1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
     {
    //     if(Input.GetKey(KeyCode.RightArrow))
    //     {
    //        deg+=angleInc;
    //     }
    //     else if(Input.GetKey(KeyCode.LeftArrow))
    //     {
    //        deg-=angleInc;
    //     }
    //     else if(Input.GetKey(KeyCode.KeypadPlus))
    //     {
    //       transform.localScale+=new Vector3 (0.01f,0.01f,0.01f);
    //     }
    //     else if(Input.GetKey(KeyCode.KeypadMinus))
    //     {
    //       transform.localScale-=new Vector3 (0.01f,0.01f,0.01f);
    //     }
    //     transform.rotation=Quaternion.Euler(new Vector3(0,deg,0));


       float xNew=Mathf.Sin(Time.time);
       transform.position+=new Vector3(xNew*0.01f,0f,0f);
       transform.rotation=Quaternion.Euler(new Vector3(0,xNew*45f,0));
       transform.localScale=Vector3.one * xNew + new Vector3(2,2,2);

        
    }
}
