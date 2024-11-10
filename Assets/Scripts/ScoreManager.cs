using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    
    [SerializeField] private CarrotZazaBehaviour zazaPoints;
    
    private int score;
    
    private void Start()
    {
        ScoreTextChanged();
    }
    
    public void IncreaseScore()
    {
        score++;
        ScoreTextChanged();
    }

    private void ScoreTextChanged()
    {
        scoreText.text = "ZaZa : " + score;
    }

    public void Props()
    {
        scoreText.text = "gay";
    }
}