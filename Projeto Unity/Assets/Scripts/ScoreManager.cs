using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static float scoreCount;
    public static float highScore;
    public int pointsPerSecond = 1;
    private TextMeshPro textObject;

    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetFloat("HighScore");
        textObject = GetComponent<TextMeshPro>();
        scoreCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        textObject.text = "Score: " + Mathf.Round(scoreCount);
        if (OnCollision.alive)
        {
            scoreCount += pointsPerSecond * Time.deltaTime;
        }
        
    }
}
