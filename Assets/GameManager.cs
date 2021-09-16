using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Text scoreDisplay;
    int points;
    int scorePoints = 10;
    public void AddScore()
    {
        points += scorePoints;
        scoreDisplay.text = "Score: " + points;
    }
}
