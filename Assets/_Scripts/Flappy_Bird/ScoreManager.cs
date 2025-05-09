using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI currentScore;
    [SerializeField] private TextMeshProUGUI hightScore;

    public static ScoreManager ins;

    private int score;

    void Awake()
    {
        ins = this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentScore.text = score.ToString();

        hightScore.text = PlayerPrefs.GetInt("hightScore", 0).ToString();
        UpdateHightScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void UpdateHightScore()
    {
        if (score > PlayerPrefs.GetInt("hightScore"))
        {
            PlayerPrefs.SetInt("hightScore", score);
            hightScore.text = score.ToString();
        }
    }

    public void UpdateScore()
    {
        score++;
        currentScore.text = score.ToString();
        UpdateHightScore();
    }
}
