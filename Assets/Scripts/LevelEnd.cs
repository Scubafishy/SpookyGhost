using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour
{


    private void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (InventoryManager.Instance.HasKey == true)
        {
            InventoryManager.Instance.SaveCoinCount();
            InventoryManager.Instance.ResetLevelCoinCount();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            Debug.Log("You need a key!");
        }
        
    }
}
