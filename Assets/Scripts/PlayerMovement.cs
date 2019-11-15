using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Camera cam;


    Vector2 movement;
    Vector2 mousePos;

    // Update is called once per frame
    void Update()
    {
        //Imports the keystrokes (left, right/ A, D)
        movement.x = Input.GetAxisRaw("Horizontal");
        //Imports the keystrokes (up, down/ W, S)
        movement.y = Input.GetAxisRaw("Vertical");

        //Takes in the mouse position in relation to the camera
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

    }


    void FixedUpdate()
    {

        //uses rigidbody physics to move the character, along with fixed time and the speed variable
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);


        //creates a vector 2 using the mouse position - the player position
        Vector2 lookDir = mousePos - rb.position;
        //created the float angle, which is the angle between the x and y coordinate, and transfers it to degress, then subtracts 90 degrees to line the player up with the mouse.
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;


    }


}