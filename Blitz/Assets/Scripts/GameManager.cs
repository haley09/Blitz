using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Player player;
    public Text scoreText;
    public GameObject gameOver;
    private int score;

    public void Play() 
    {
        score = 0;
        scoreText.text = score.ToString();
        gameOver.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

        Asteroids[] asteroids = FindObjectsOfType<Asteroids>();

        for (int i = 0; i < asteroids.Length; i++) {
            Destroy(asteroids[i].gameObject);
        }
    }

    public void Pause() 
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }

    public void GameOver() 
    {
        gameOver.SetActive(true);

    }

    // Currently no score to keep track of
    public void IncreaseScore() 
    {
        score++;
        scoreText.text = score.ToString();
    }

}
