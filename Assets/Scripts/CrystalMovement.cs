using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CrystalMovement : MonoBehaviour
{

    /*Setting speed of the movement*/
    public float movementSpeed;


    // Update is called once per frame
    private void Update()
    {   
        /*Transforms gameobject's position by multiplying, the movement speed and Deltatime*/
        transform.position += Vector3.left * movementSpeed * Time.deltaTime;

        //rb.MovePosition(transform.position += Vector3.left * movementSpeed * Time.deltaTime);
    }
}
