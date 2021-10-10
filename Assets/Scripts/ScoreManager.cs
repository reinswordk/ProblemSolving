using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    private static ScoreManager _instance = null;
    public static ScoreManager Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = FindObjectOfType<ScoreManager>();
                if(_instance  == null)
                {
                    Debug.LogError("Fatal Error: Score Manager not found");
                }
            }
            return _instance;
        }
    }
    public static int score;
    public Text text;

    void Start()
    {
        score = 0;
    }


    public void AddScore(int skor)
    {
        score += skor;
        text.text = "Score: " + score;
    }
}
