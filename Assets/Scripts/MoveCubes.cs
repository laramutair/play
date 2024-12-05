using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCubes : MonoBehaviour
{
   public GameObject [] cubes;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xNew=Mathf.Sin(Time.time);
        float deplacment=0f;
        // foreach(GameObject cube in cubes)
        // {
        //     float xNew=Mathf.Sin(Time.time);
        //     cube.transform.rotation=Quaternion.Euler(new Vector3(0, xNew * 45f + deplacment ,0));
        //     deplacment+=3f;
        // }
      
        for(int i=0 ; i<cubes.Length ; i++ )
        {
            
            cubes[i].transform.position+=new Vector3(0f,xNew *Time.deltaTime,0f);
        }
        cubes[0].transform.rotation=Quaternion.Euler(new Vector3(0, xNew * 45f,0));
        cubes[1].transform.rotation=Quaternion.Euler(new Vector3(0, 0,xNew * 45f));
    }
}
