using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject GameOver;
    [SerializeField] private GameObject MainGame;

    public static GameManager ins;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ins = this;
        Time.timeScale = 0f;
    }

    public void CheckGameOver()
    {
        GameOver.SetActive(true);
        Time.timeScale = 0f;
    }

    public void PlayGame()
    {
        MainGame.SetActive(false);
        Time.timeScale = 1f;
    }

    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
