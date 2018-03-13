using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVision : MonoBehaviour
{
    [SerializeField]
    float visionAngle = 15.0f;

    List<GameObject> enemiesList;

    Vector3 enemyDirection;
    float enemyAngle;

    static Vector3 mousePosition;
    Vector3 WorldMousePosition;



    void Start()
    {
        mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        enemiesList = new List<GameObject>();
        WorldMousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        enemiesList.AddRange(GameObject.FindGameObjectsWithTag("Enemy"));
    }

    void Update()
    {
        mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        WorldMousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector3 lookPos = WorldMousePosition - transform.position;

        foreach (var enemy in enemiesList)
        {
            float dist = Vector3.Distance(enemy.transform.position, this.transform.position);
            enemyDirection = enemy.transform.position - this.gameObject.transform.position;
            enemyAngle = Vector3.Angle(enemyDirection, lookPos);

            if (enemyAngle <= visionAngle && dist < 3.5)
            {
                enemy.GetComponent<EnemyMovement>().BeingWatched();
            }
            else
            {
                enemy.GetComponent<EnemyMovement>().NotBeingWatched();
            }
        }
    }
}
