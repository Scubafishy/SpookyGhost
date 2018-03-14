using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour {

    Text scoreText;

	void Awake () {
        scoreText = GetComponent<Text>();
	}

    private void Start()
    {
        scoreText.text = string.Format("Score: {0}", InventoryManager.Instance.CoinCount);
    }

}
