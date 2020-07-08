using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    //Config params
    [Range(0.1f,10f)][SerializeField] float gameSpeed = 1f;
    [SerializeField] int pointsPerBlockDestroyed = 83;

    //State variables
    [SerializeField] int currentScore = 0;

    //cached reference

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;
        
    }

    public void AddToScore()
    {
        currentScore += pointsPerBlockDestroyed;
    }
}
