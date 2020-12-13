﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{

    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;

    // Use this for initialization
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {

        NextGuess();

    }

    public void onPressHigher()
    {
        min = guess+1;
        NextGuess();
    }

    public void onPressLower()
    {
        max = guess-1;
        NextGuess();
    }

    void NextGuess()
    {
        guess = Random.Range(max, min);
        guessText.text = guess.ToString();
    }
}
