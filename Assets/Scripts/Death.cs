using UnityEngine;
using TMPro;

public class Death : MonoBehaviour
{
    public bool isDead;
    [SerializeField] private GameObject deathscreen;
    public TextMeshProUGUI finalScoreText;
    [SerializeField] private ScoreManager manager;

    private bool deathHandled = false;

    private void Start()
    {
        isDead = false;
        deathscreen.SetActive(false);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Hazard"))
        {
            Debug.Log("Touched by Hazard");
            isDead = true;
        }
    }

    private void Update()
    {
        if (isDead && !deathHandled)
        {
            deathscreen.SetActive(true);
            DisplayScore();
            deathHandled = true;
        }
    }

    public void DisplayScore()
    {
        if (manager != null && finalScoreText != null)
        {
            int finalScore = manager.GetFinalScore();
            finalScoreText.text = "Final Score: " + finalScore.ToString();
        }
    }
}

