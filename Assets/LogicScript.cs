using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int playerScore;
    public GameObject gameOverScreen;
    public Text scoreText;
    [ContextMenu("Increase Score")]
    public void addScore()
    {
        playerScore = playerScore + 1;
        scoreText.text=playerScore.ToString();
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
