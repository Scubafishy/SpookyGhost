using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinText : MonoBehaviour
{

    Text coinCountText;

    // Use this for initialization
    void Start()
    {
        coinCountText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        coinCountText.text = string.Format("Coins Collected in Level: {0}/{1} \nTotal Coins: {2}", InventoryManager.Instance.collectedCoinsInLevel, InventoryManager.Instance.coinsInLevel, InventoryManager.Instance.CoinCount);
    }
}
