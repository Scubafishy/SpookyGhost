using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLivesText : MonoBehaviour
{
    Text playerLifeText;
    PlayerLives lives;

	void Start()
    {
        playerLifeText = this.gameObject.GetComponent<Text>();
        lives = GameObject.FindGameObjectWithTag("Player Lives").GetComponent<PlayerLives>();
	}
	
	void Update()
    {
        playerLifeText.text = "Lives Remaining: " + lives.NumberOfLivesRemaining;
    }
}
