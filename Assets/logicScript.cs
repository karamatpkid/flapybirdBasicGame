using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class logicScript : MonoBehaviour
{

    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;

    // Start is called before the first frame update
 
    [ContextMenu("Increase Score")]
    public void addScore()
    {
        playerScore = playerScore + 1;
        scoreText.text = playerScore.ToString();
    }
    public void restartGame()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
       // SceneManager.LoadScene("level1");
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

}
