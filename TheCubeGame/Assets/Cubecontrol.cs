using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubecontrol : MonoBehaviour
{
    public Transform cubeTemplate;
    private const string V = "w";
    private float turningspeed = 180;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
          
        transform.position += Vector3.up* Time.deltaTime;
        if (Input.GetKey(KeyCode.DownArrow))

            transform.position += Vector3.down* Time.deltaTime;
        if (Input.GetKey(KeyCode.LeftArrow))

            transform.position += Vector3.left* Time.deltaTime;
        if (Input.GetKey(KeyCode.RightArrow))

            transform.position += Vector3.right * Time.deltaTime;
        if (true)
        {
            if (Input.GetKey(KeyCode.A))

                transform.Rotate(Vector3.left,-turningspeed* Time.deltaTime);

            if (Input.GetKey(KeyCode.W))

                transform.Rotate(Vector3.up, -turningspeed * Time.deltaTime);

            if (Input.GetKey(KeyCode.S))

                transform.Rotate(Vector3.down, -turningspeed * Time.deltaTime);


            if (Input.GetKey(KeyCode.D))

                transform.Rotate(Vector3.right, turningspeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))
            Instantiate(cubeTemplate,
                                transform.position - transform.forward,
                                Quaternion.identity);
                                    
        {

        }
    }
}
