using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour {


    Scene currentScene;
    private void Start()
    {
        currentScene = SceneManager.GetActiveScene();
    }

    void RestartLevel()
    {
        InventoryManager.Instance.ResetToSavedCoinCount();
        InventoryManager.Instance.ResetLevelCoinCount();
        SceneManager.LoadScene(currentScene.name);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            RestartLevel();
        }
    }
}
