using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    #region Singleton
    private static ScoreManager instance_ = null;
    public static ScoreManager Instance
    {
        get
        {
            if (instance_ == null)
            {
                instance_ = FindObjectOfType<ScoreManager>();

            }
            return instance_;
        }
    }

    #endregion

    public Text scoreText;
    public int currentScore;
    private void Start()
    {
        currentScore = 0;
    }
    public void AddScore()
    {
        currentScore++;
        scoreText.text = "Score: " + currentScore;
    }

















}
