using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class PongManager : MonoBehaviour
{
    int scoreP1 = 0;
    int scoreP2 = 0;
    public Text ScoreText1;
    public Text ScoreText2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ScoreText1.text = scoreP1.ToString();
        ScoreText2.text = scoreP2.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScoreChange(int score1, int score2)
    {
        scoreP1 = score1;
        scoreP2 = score2;
        ScoreText1.text = scoreP1.ToString();
        ScoreText2.text = scoreP2.ToString();
    }
}
