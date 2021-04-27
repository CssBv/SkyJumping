using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Scoring : MonoBehaviour
{
    
    /*Set a TextMeshPro instance named text*/
    public TextMeshProUGUI text;

    public int score;
    
  
   
    void Start()
    {
        /*Get Conponent TextMesh fro*/
        //score = GetComponent<TextMeshProUGUI>();
        text.ForceMeshUpdate(true);

        /*Set Score to 0*/
        score = 0;

    }

    void Update()
    {   
        /*Set score in TextMeshPro's text property*/
        text.text = score.ToString();
        
    }

} 