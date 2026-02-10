using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI myUI;
    public float score;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Public Score
    public void AddScore(int value)
    {
        score +- value;
        Debug.Log("Score =" + score);
        myUI.text = "Score:" score.ToString();
    }
}
