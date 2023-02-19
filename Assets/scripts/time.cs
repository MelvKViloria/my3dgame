using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour
{
    public Text timeText;
    private float startTime;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        float t = Time.time - startTime;
        string minutes = Mathf.Floor(t / 60).ToString("00");
        string seconds = Mathf.Floor(t % 60).ToString("00");

        timeText.text = minutes + ":" + seconds;
    }
}