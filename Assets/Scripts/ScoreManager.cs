using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; }
    public Text pointsText, MaxPointsText;

    [SerializeField] private int points = 0;
    
    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        UpdateMaxPoints();
    }

    public void IncreasePoints()
    {
        points++;
        pointsText.text = points.ToString();
        UpdateMaxPoints();
    }

    public void UpdateMaxPoints()
    {
        int maxPoints = PlayerPrefs.GetInt("Max", 0);
        if (points >= maxPoints)
        {
            maxPoints = points;
            PlayerPrefs.SetInt("Max", maxPoints);
        }

        MaxPointsText.text = "BEST: " + maxPoints.ToString();
    } 
}
