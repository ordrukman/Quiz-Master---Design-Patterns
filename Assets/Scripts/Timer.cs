using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToComplateQuestion = 30f;
    [SerializeField] float timeToShowCorectAnswer = 10f;

    public bool loadNextQuestion;
    public float fillFraction;

    public bool isAnsweringQuestion;
    float timerValue;

    void Update()
    {
        UpdateTimer();
    }

    public void CancelTimer() {
        timerValue = 0;
    }
    void UpdateTimer() {
        timerValue -= Time.deltaTime;

        if(isAnsweringQuestion) {
             if(timerValue > 0) {
                fillFraction = timerValue / timeToComplateQuestion;
             } else {
                 isAnsweringQuestion = false;
                 timerValue = timeToShowCorectAnswer;
             }
        } else {
            if(timerValue > 0) {
                fillFraction = timerValue / timeToShowCorectAnswer;
             } else {
                 isAnsweringQuestion = true;
                 timerValue = timeToComplateQuestion;
                 loadNextQuestion = true;
             }
             
        }
    }
}
