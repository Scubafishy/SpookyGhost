using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public bool HasKey { get; private set; }


    private static InventoryManager instance;

    public static InventoryManager Instance
    {
        get
        {
            if (instance == null)
            {
                var go = new GameObject(name: typeof(InventoryManager).Name);
                instance = go.AddComponent<InventoryManager>();
                
            }

            return instance;
        }
    }

    #region Coin Stuff
    public int CoinCount { get; private set; }

    public int savedCoinCount;

    public int coinsInLevel;

    public int collectedCoinsInLevel;

    

    public void AddCoin()
    {
        CoinCount++;
        collectedCoinsInLevel++;
    }

    public void ResetCoinCount()
    {
        CoinCount = 0;
    }

    public void ResetLevelCoinCount()
    {
        collectedCoinsInLevel = 0;
    }

    public void SaveCoinCount()
    {
        savedCoinCount = CoinCount;
    }

    public void ResetToSavedCoinCount()
    {
        CoinCount = savedCoinCount;
    }

    public void FindAllCoinsInLevel()
    {
        GameObject[] coins = GameObject.FindGameObjectsWithTag("Coin");
        coinsInLevel = coins.Length;
    }
    #endregion

    #region Key Stuff

    public void GetKey()
    {
        HasKey = true;
    }

    #endregion

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        FindAllCoinsInLevel();
    }

}
