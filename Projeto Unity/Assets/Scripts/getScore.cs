﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using DitzeGames.Effects;

public class getScore : MonoBehaviour
{
    public static float score;
    public bool GameIsPaused = false;
    public GameObject endGame;
    public GameObject scoreText;
    public GameObject highScoreText;
    public GameObject joystickCanvas;

    private TextMeshProUGUI textScore;
    private TextMeshProUGUI textHighScore;
    

    void Start()
    {
        textScore = scoreText.GetComponent<TextMeshProUGUI>();
        textHighScore = highScoreText.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!OnCollision.alive)
        {
            Pause();
        }
        
    }

    void Restart()
    {
        endGame.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void Pause()
    {

        
        verifyHighScore();
        textHighScore.text = ScoreManager.highScore.ToString();
        score = Mathf.Round(ScoreManager.scoreCount);
        textScore.text = score.ToString();

        endGame.SetActive(true);
        joystickCanvas.SetActive(false);


        GameIsPaused = true;
    }

    void verifyHighScore()
    {
        if(ScoreManager.highScore < score)
        {
            PlayerPrefs.SetFloat("HighScore", score);
            ScoreManager.highScore = score;
        }
    }
}
