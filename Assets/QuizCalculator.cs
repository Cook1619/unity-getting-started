﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizCalculator : MonoBehaviour
{
    // Start is called before the first frame update
    public float quiz1, quiz2, quiz3, quiz4, quiz5;



    void Start()
    {   
        quiz1 = Random.Range(0, 100f);
        quiz2 = Random.Range(0, 100f);
        quiz3 = Random.Range(0, 100f);
        quiz4 = Random.Range(0, 100f);
        quiz5 = Random.Range(0, 100f);

        float average = (quiz1 + quiz2 + quiz3 + quiz4 + quiz5) / 5;
        average = Mathf.Round(average * 100f) / 100f;
        Debug.Log("Average quiz score: " + average);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
