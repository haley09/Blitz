using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Stopwatch : MonoBehaviour
{
    public Text TimeText;
    float currentTime;
    private bool flag = false;

    // Score
    int score;
    public Text scoreText;
    public float multiplier = 5;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(!flag) {
            currentTime = currentTime + Time.deltaTime;
        }
        score = Mathf.RoundToInt(currentTime * multiplier);
        scoreText.text = score.ToString();
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        TimeText.text = time.ToString(@"mm\:ss\:fff");
    }

    public void Reset() {
    flag = true;
    score = 0;
    scoreText.text = score.ToString();
  }

}
