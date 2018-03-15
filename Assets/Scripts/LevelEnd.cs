using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelEnd : MonoBehaviour
{
    [SerializeField]
    Text needKeyText;

    private void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (InventoryManager.Instance.HasKey == true)
        {
            InventoryManager.Instance.SaveCoinCount();
            InventoryManager.Instance.ResetLevelCoinCount();
            InventoryManager.Instance.ResetKey();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            needKeyText.enabled = true;
            StartCoroutine(ShowKeyText());
        }
        
    }

    IEnumerator ShowKeyText()
    {
        yield return new WaitForSecondsRealtime(5.0f);

        needKeyText.enabled = false;
    }
}
