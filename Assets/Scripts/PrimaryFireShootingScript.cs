using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PrimaryFireShootingScript : MonoBehaviour
{


    public GameObject bulletPrefab;
    public Transform playerMuzzle;

    public float bulletVelocity = 30f;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {

            //if(curAmmo > 0)

            Shoot();

            
        }

    }


    private void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, playerMuzzle.position, playerMuzzle.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(playerMuzzle.up * bulletVelocity, ForceMode2D.Impulse);
        Destroy(bullet, 5f);
    }


}
