using UnityEngine;
using TMPro;  

public class ScoreManager : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;
    public float score = 0f;

    void Update()
    {
        if (player.position.y > score)
        {
            score = player.position.y;
        }

        scoreText.text = "Score: " + Mathf.FloorToInt(score).ToString();       
        
    }

    public int GetFinalScore() 
    {
        return Mathf.FloorToInt(score);
    }
}

