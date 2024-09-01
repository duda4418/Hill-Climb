using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayDistanceText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI distanceText;
    [SerializeField] private Transform playerTrans;

    private Vector2 startPosition;

    private void Start()
    {
        startPosition = playerTrans.position;
    }

    private void Update()
    {
        Vector2 distance = (Vector2)playerTrans.position - startPosition;
        distance.y = 0f;

        if (distance.x < 0)
        {
            distance.x = 0;
        }

        distanceText.text = "Distance: " + distance.x.ToString("F0") + "m";
    }
}
