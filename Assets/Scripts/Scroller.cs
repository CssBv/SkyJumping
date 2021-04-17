using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour
{   
    /*Create box collider variable*/
    public BoxCollider2D boxCollider;

    /*Create Rigidbody variable*/
    public Rigidbody2D rb;


    private float width; 

    private float scrollSpeed = -5;

d Dk
    void Start()
    {   
        /*Get Collider from gameobject*/
        boxCollider = GetComponent<BoxCollider2D>();
        /*Get rigidbody from component*/
        rb = GetComponent<Rigidbody2D>();

        /*Obtain width with collider*/
        width = boxCollider.size.x;

        /*Disable collider's calculations*/
        boxCollider.enabled = false;

        /*Position and direction of rigidbody with Vector2. x as first paremeter, y as second  parameter. Scroll image to the left*/
        rb.velocity = new Vector2(scrollSpeed, 0);   
    }

    // Update is called once per frame
    void Update()
    {   
        /*If position in x is less than  negative width*/
        if(transform.position.x < -width)
        {   
            /*Reset background's position by creating vector 2 that has as argument x  (multuplies width * 2 (background twin )in x position)  and 0 in y */
            Vector2 resetPosition = new Vector2(width * 2f, 0);
            /*Store the position of gameobject's transform. Equal it to transform.position plus resetPosition and cast the sum into a Vector2*/
            transform.position = (Vector2)transform.position + resetPosition;
        }
    }
}
 