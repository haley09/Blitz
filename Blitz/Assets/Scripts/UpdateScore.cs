using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateScore : MonoBehaviour {
  public Text scoreText;
  public double score;
  public float increasedPerSecond; 
  private bool flag = false;
  // Start is called before the first frame update

  
  public void Start() {
    score = 0f;
    increasedPerSecond = 1f; 
  }

  // Update is called once per frame
  public void Update() {
    if(!flag) {
      score += Math.Truncate(Time.time);
      scoreText.text = score.ToString();
    }
  }

  public void Reset() {
    flag = true;
    score = 0;
    scoreText.text = score.ToString();
  }

}
