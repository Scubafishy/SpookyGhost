using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    Scene currentScene;

    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (GameObject.FindGameObjectWithTag("Player Lives").GetComponent<PlayerLives>().NumberOfLivesRemaining > 0)
            {
                GameObject.FindGameObjectWithTag("Player Lives").GetComponent<PlayerLives>().LoseLife();
                RestartLevel();
            }
            else
            {
                SceneManager.LoadScene("Lose");
            }
        }
    }

    void RestartLevel()
    {
        InventoryManager.Instance.ResetToSavedCoinCount();
        InventoryManager.Instance.ResetLevelCoinCount();
        InventoryManager.Instance.ResetKey();
        SceneManager.LoadScene(currentScene.name);
    }
}
