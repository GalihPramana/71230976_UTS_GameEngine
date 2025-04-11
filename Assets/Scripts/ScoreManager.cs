using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public Text scoreText; 
    private int maxScore = 150;
    private int minScore = -20;

    void Update()
    {
        // Cek apakah skor sudah mencapai batas
        if (score >= maxScore || score <= minScore)
        {
            GameOver();
        }

    }


    void GameOver()
    {
        SceneManager.LoadScene("Gameover"); // Pastikan nama scene sesuai
    }
}
