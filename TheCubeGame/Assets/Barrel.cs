using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 250;
    public float cooldownTime = 5;
    private float nextFireTime = 60;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  if(Time.time > nextFireTime)
        {
            if (Input.GetKeyDown(KeyCode.Space))

            {
                print("Shot fired, cooldown started");
                nextFireTime = Time.time + cooldownTime;
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {


            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.up * bulletSpeed;
        }
    }
}
