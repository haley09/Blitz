using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateScore : MonoBehaviour {
  public Text scoreText;
  public float score;
  public float increasedPerSecond; 
  // Start is called before the first frame update
  void Start() {
    score = 0f;
    increasedPerSecond = 1f; 
  }

  // Update is called once per frame
  void Update() {
    Debug.Log(GameObject.Find("gameOver"));
    score += Time.deltaTime * increasedPerSecond; 
    scoreText.text = score.ToString();
  }

  void ResetScore() {
    score = 0;
  }
}
