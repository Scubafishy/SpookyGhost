using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyText : MonoBehaviour {

    Text keyText;
    
    // Use this for initialization
	void Start () {
        keyText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        if (InventoryManager.Instance.HasKey == true)
        {
            keyText.text = "You have the Key!";
        }

        else
        {
            keyText.text = "No key in inventory!";
        }

        
	}
}
