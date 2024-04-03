using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
	public int playerScore;
	public Text score;
	public GameObject gameOverScreen;
	public int hScore;
	public Text hscoreText;

	[ContextMenu("Increase Score")]
	public void addScore(int scoreToAdd)
	{
		playerScore = playerScore + scoreToAdd;
		score.text = playerScore.ToString();
		if (hScore < playerScore) 
		{
			PlayerPrefs.SetInt("Highscore", playerScore);
		}
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
