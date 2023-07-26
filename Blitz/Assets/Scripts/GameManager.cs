using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

  public Player player;
  public Text scoreText;
  //public GameObject playButton;
  public GameObject quitButton;
  public GameObject gameOver;
  private float score;

  private void Awake() {
    Application.targetFrameRate = 60;
    //Pause();
  }

  public void Play() {
    // TODO[]: Fix score after reseting in UpdateScore()
    // We may need to include this in the same script
    score = 0;
    scoreText.text = score.ToString();
    //playButton.SetActive(false);
    gameOver.SetActive(false);
    GetComponent<UpdateScore>().Update();
    Time.timeScale = 1f;
    player.enabled = true;

    Asteroids[] asteroids = FindObjectsOfType<Asteroids>();

    for (int i = 0; i < asteroids.Length; i++) {
      Destroy(asteroids[i].gameObject);
    }
  }

  public void Pause() {
    Time.timeScale = 0f;
    player.enabled = false;
  }

  public void QuitGame () {
      Debug.Log("QUIT!");
      Application.Quit();
  }

  public void GameOver() {
    //Call stop function in update score and reset
    gameOver.SetActive(true);
    //playButton.SetActive(true);
    //Pause();
    score = 0;
    scoreText.text = score.ToString();
  }
}
