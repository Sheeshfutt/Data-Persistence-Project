using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HSManager : MonoBehaviour
{
    public Text HSText;
    string highPlayer = "Name";
    string player = "NewName";

    int highScore = 0;

    private void Start()
    {
        if (PersistenceManager.Instance != null)
        {
            highPlayer = PersistenceManager.Instance.highPlayer;
            highScore = PersistenceManager.Instance.highScore;
            player = PersistenceManager.Instance.player;
            HSText.text = "Best Score : " + highPlayer + " : " + highScore;
        }
    }

    public void UpdateHS(int newScore)
    {
        if (highScore < newScore)
        {
            highPlayer = player;
            highScore = newScore;
            HSText.text = "Best Score : " + highPlayer + " : " + highScore;
            if (PersistenceManager.Instance != null)
            {
                PersistenceManager.Instance.highScore = highScore;
                PersistenceManager.Instance.highPlayer = highPlayer;
                PersistenceManager.Instance.SaveHighScore();
            }
        }
    }    
}
