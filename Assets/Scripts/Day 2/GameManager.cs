using UnityEngine;
using UnityEngine.UI; 

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int score = 0;
    public int highScore = 0;

    public Text scoreText;     
    public Text highScoreText;  

    void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);

        highScore = PlayerPrefs.GetInt("HighScore", 0);
        UpdateUI();
    }

    public void AddScore(int amount)
    {
        score += amount;

        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
        }

        UpdateUI();
    }

    void UpdateUI()
    {
        if (scoreText != null)
            scoreText.text = "Score : " + score;

        if (highScoreText != null)
            highScoreText.text = "High Score : " + highScore;
    }
}
