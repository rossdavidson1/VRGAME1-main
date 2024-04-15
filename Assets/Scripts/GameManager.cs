using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; // Singleton instance

    public TextMeshProUGUI scoreText; // Reference to the UI text displaying the score
    private int score = 0; // Current score

    private void Awake()
    {
        // Ensure only one instance of GameManager exists
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Method to add points to the score
    public void AddPoints(int points)
    {
        score += points;
        UpdateScoreUI();

        if (score >= 6)
        {
            // Load the WinScene
            SceneManager.LoadScene("YouWin");
        }
    }

    //Method to update the score displayed in the UI
    void UpdateScoreUI()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}