using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;

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
        myUI.text = score.ToString();
    }
    //Public Score
    public void AddScore(int value)
    {
        score += value;
        Debug.Log("Score =" + score);
        string v = "Score:" + score.ToString();
        myUI.text = v;
    }
}
