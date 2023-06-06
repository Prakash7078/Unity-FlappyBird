using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class LogicManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int playerScore;
    public Text scoreText;
    
    public void addScore()
    {
        playerScore = playerScore + 1;
        scoreText.text = playerScore.ToString();
    }
}
