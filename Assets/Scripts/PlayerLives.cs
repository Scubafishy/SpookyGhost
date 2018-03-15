using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLives : MonoBehaviour
{
    static PlayerLives instance = null;

    int numberOfLivesRemaining;
    public int NumberOfLivesRemaining
    {
        get
        {
            return numberOfLivesRemaining;
        }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    void Start()
    {
        numberOfLivesRemaining = 3;
    }

    public void LoseLife()
    {
        numberOfLivesRemaining--;
    }

    public void GainLife()
    {
        numberOfLivesRemaining++;
    }
}