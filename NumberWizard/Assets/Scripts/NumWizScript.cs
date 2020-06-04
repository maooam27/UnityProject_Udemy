using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumWizScript : MonoBehaviour
{
    int maxNum = 1000;
    int minNum = 1;
    int guess = 500;

    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        Debug.Log("Welcome to number wizard!! I'll guess your number!");
        Debug.Log("Now, you need to choose a number between: " + minNum + " to " + maxNum);
        Debug.Log("Is your number higher or lower than 500?");
        Debug.Log("For give the answer, press \"Up\" (for higher) or \"Down\" (for lower)");
        maxNum = maxNum + 1;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            minNum = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxNum = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I am the KING");
            StartGame();
        }
    }
    void NextGuess()
    {
        guess = (maxNum + minNum) / 2;
        Debug.Log("So, your guess is " + guess + "? Continue pressing up and down");
    }
}
