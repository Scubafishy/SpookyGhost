using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {


    private SpriteRenderer spriteRenderer;
    private BoxCollider2D boxCollider2D;


    private void Start()
    {
        
        spriteRenderer = GetComponent<SpriteRenderer>();
        boxCollider2D = GetComponent<BoxCollider2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            InventoryManager.Instance.AddCoin();
            spriteRenderer.enabled = false;
            boxCollider2D.enabled = false;

        }


    }


    
}
