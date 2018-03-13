using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnemy : MonoBehaviour {
    [SerializeField]
    GameObject Enemy;

    EnemyMovement enemyMovement;

    private void Start()
    {
        enemyMovement = Enemy.GetComponent<EnemyMovement>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        enemyMovement.enabled = true;
    }
}
