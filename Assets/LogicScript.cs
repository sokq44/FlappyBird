using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public static bool birdIsAlive;

    public Text scoreText;
    public GameObject gameOverScreen;

    [ContextMenu("Increase Score")]
    public void AddScore(int scoreToAdd)
    {
        this.playerScore += scoreToAdd;
        this.scoreText.text = this.playerScore.ToString();
    }

    [ContextMenu("Restart Game")]
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    [ContextMenu("Game over")]
    public void gameOver()
    {
        this.gameOverScreen.SetActive(true);
    }

    
}
