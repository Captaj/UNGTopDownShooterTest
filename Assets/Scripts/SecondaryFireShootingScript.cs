using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SecondaryFireShootingScript : MonoBehaviour
{


    public GameObject secondaryBulletPrefab;
    public Transform secondaryPlayerMuzzle;

    public float bulletVelocity = 15f;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire2"))
        {

            //if(curAmmo > 0)

            ShootSecondary();

            
        }

    }


    private void ShootSecondary()
    {
        GameObject secondaryBullet = Instantiate(secondaryBulletPrefab, secondaryPlayerMuzzle.position, secondaryPlayerMuzzle.rotation);
        Rigidbody2D rb = secondaryBullet.GetComponent<Rigidbody2D>();
        rb.AddForce(secondaryPlayerMuzzle.up * bulletVelocity, ForceMode2D.Impulse);
        Destroy(secondaryBullet, 5f);
    }


}
