using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    [SerializeField]

    private GameObject credits;

    private void Start()
    {
        credits.gameObject.SetActive(false);
    }

    public void OnStartTap() 
    {
        SceneManager.LoadScene("BalloonRush");
    }

    public void OnDeathTap() 
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void OnExitTap() 
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif 
        Application.Quit();
    }

    public void CreditsTap() 
    {
        credits.gameObject.SetActive(true);
    }

    public void BackTap()
    {
        credits.gameObject.SetActive(false);
    }
}
