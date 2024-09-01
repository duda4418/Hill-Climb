using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayDistanceText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI distanceText;
    [SerializeField] private Transform playerTrans;
    [SerializeField] private TextMeshProUGUI highScoreText;

    private int highScore;
    private Vector2 startPosition;

    private void Start()
    {
        startPosition = playerTrans.position;
        highScore = PlayerPrefs.GetInt("highScore", 0);
        highScoreText.text = "High Score: " + highScore.ToString() + "m";
    }

    private void Update()
    {
        Vector2 distance = (Vector2)playerTrans.position - startPosition;
        distance.y = 0f;

        if (distance.x < 0)
        {
            distance.x = 0;
        }

        if (distance.x > highScore)
        {
            highScore = (int)distance.x;
            highScoreText.text = "High Score: " + highScore.ToString() + "m";
            PlayerPrefs.SetInt("highScore", highScore);
        }

        distanceText.text = "Distance: " + distance.x.ToString("F0") + "m";
    }
}
