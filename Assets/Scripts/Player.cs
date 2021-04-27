using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   
    /*Setting Jumping speed of the player*/
    //[SerializeField]
    private float jumpSpeed = 400f;

    /*Setting rigidbody of character*/
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {   
        /*Obtain Rigidbody Component */
        rb.GetComponent<Rigidbody2D>();
    }

    void Update()
    {

    }

    /*Detect touch*/
    void FixedUpdate()
    {   

        /*If screen is touched then make character to jump*/
        if(Input.GetMouseButtonDown(0) || Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) //--> Touch screen: Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began ----- Input.GetKeyDown(KeyCode.Space )
        {   
            //Debug.Log("");

            /*Add force to the rigidbody. AddForce takes two arguments: Vector2 and Force meode. In this case, takes Impulse. Create Vector2 that
            sets x and y as the speed of the jump. Force equals to mass * acceleration*/
            //rb.AddForce( new Vector2(0f, jumpSpeed), ForceMode2D.Impulse);

            /*Stopping player*/
            rb.velocity = Vector2.zero;

            /*If mouse is pressed then move object up with Vector2 and multiply it by jumpSpeed. 
             All of this by adding a force method to player's rigidbody*/
            rb.AddForce(Vector2.up * jumpSpeed);

        }      
    }
}
