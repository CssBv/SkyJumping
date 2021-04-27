using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CrystalMovement : MonoBehaviour
{

    /*Setting speed of the movement*/
    private float movementSpeed = 4;
    private float randomRange = 4f;


    // Update is called once per frame
    private void Update()
    {   
        /*Transforms gameobject's position by multiplying, the movement speed and Deltatime*/
        transform.position += Vector3.left * movementSpeed * Time.deltaTime;

        /*When the crystal reaches -4.8 in x axis reset it's position */
        if(transform.position.x <= -4.8)
        {   
            /*Set them in 15x coordinate and keep the position of y and z axis*/
            transform.position = new Vector3(15, transform.position.y, transform.position.z);

            /*Setting random height of obstacles*/
            /*Unity Random Range takes two arguments.  Max limit and min limit*/
            float randomHeight = UnityEngine.Random.Range(-randomRange, randomRange);
        }
    }
}
 