using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
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
}
