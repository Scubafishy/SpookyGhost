using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    [SerializeField]
    string sceneToLoad;

    public void LoadSceneButtonClicked()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void ExitButtonClicked()
    {
        Application.Quit();
    }

    public void PlayButtonCLicked()
    {
        SceneManager.LoadScene("Level1");
        InventoryManager.Instance.ResetCoinCount();
        InventoryManager.Instance.ResetKey();
        InventoryManager.Instance.ResetLevelCoinCount();
        GameObject.FindGameObjectWithTag("Player Lives").GetComponent<PlayerLives>().ResetLives();
    }
}
