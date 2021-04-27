using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreDetection : MonoBehaviour
{
    /*Create Scoring instance named scoring*/
    public Scoring scoring;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        /*Increment score by one*/
        scoring.score++;
    }

}
 