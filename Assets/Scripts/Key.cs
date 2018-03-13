using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

    private SpriteRenderer spriteRenderer;
    private BoxCollider2D boxCollider2D;

    // Use this for initialization
    void Start () {
        spriteRenderer = GetComponent<SpriteRenderer>();
        boxCollider2D = GetComponent<BoxCollider2D>();
    }
	

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            InventoryManager.Instance.GetKey();
            spriteRenderer.enabled = false;
            boxCollider2D.enabled = false;

        }
    }
}
