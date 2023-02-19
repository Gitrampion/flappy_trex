using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource dingSFX;
    public int highScoree;
    public Text highScoreeText;
    public int score;
    public Text textScore;
    public static LogicScript instance;


    private void Awake()
    {
        instance = this;

        if (PlayerPrefs.HasKey("SaveScore"))
        {
            highScoree = PlayerPrefs.GetInt("SaveScore");
        }
    }

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        score = playerScore;
        scoreText.text = playerScore.ToString();
        textScore.text = score.ToString();
        HighScore();
        highScoreeText.text = highScoree.ToString();
        dingSFX.Play();
    }



    public void HighScore()
    {
        if (score > highScoree)
        {
            highScoree = score;
            PlayerPrefs.SetInt("SaveScore", highScoree);
        }
    }

    public void ResetScore()
    {
        score = 0;
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);

    }
}
