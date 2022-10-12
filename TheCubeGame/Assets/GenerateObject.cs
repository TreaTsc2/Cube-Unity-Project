using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObject : MonoBehaviour
{
   
    private float turningspeed = 180;


    public Transform cubeTemplate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.B))
        {
            Instantiate(cubeTemplate);

        }
    }
}
