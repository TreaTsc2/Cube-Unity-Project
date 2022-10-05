using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apply_forces : MonoBehaviour
{
    Rigidbody ourRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        ourRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            ourRigidbody.AddForce(1 * Vector3.left);
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            ourRigidbody.AddExplosionForce(2000,transform.position + Vector3.up,1);
         }
    }
    private void OnCollisionEnter(Collision collision)
    {
        collision.transform.position += Vector3.down;
    }
}