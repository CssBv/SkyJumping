using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crystal : MonoBehaviour
{
    /*Detect collision between player and obstacle*/
   private void OnCollisionEnter2D(Collision2D collission)
    {   
        /*If condition is true (Detect if Component it's colliding is player then reload the scene)*/
        if(collission.collider.GetComponent<Player>() != null)
        {   /*Reload Scene*/
            SceneManager.LoadScene(0);    
        }
    } 
}
 