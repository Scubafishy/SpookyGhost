using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    float movementSpeed;

    [SerializeField]
    Transform Player;
    

    float distanceToPlayer;
    float step;

    bool isStunned = false;
    bool isFirstTimeAfterLookingAway = true;

    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (!isStunned)
        {
            distanceToPlayer = Vector2.Distance(this.gameObject.transform.position, Player.position);

            if (distanceToPlayer < 20.0f)   //TODO: test to find correct distance
            {
                //if (distanceToPlayer < 5.0f)
                //{
                //  step = movementSpeed * Time.deltaTime * (1 / 5);
                //}
                //else
                //{
                    step = movementSpeed * Time.deltaTime * (1 / distanceToPlayer);
                //}

                transform.position = Vector3.MoveTowards(transform.position, Player.position, step);
            }
        }
        anim.SetFloat("MoveX",Player.position.x);
        anim.SetFloat("MoveY",Player.position.y);
        anim.SetBool("GhostHiding",isStunned);
        anim.SetFloat("LastX",Player.position.x);
        anim.SetFloat("LastY",Player.position.y);
    }

    public void BeingWatched()
    {
        isStunned = true;
    }

    public void NotBeingWatched()
    {
        StartCoroutine(Stun());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }

    IEnumerator Stun()
    {
        if (isFirstTimeAfterLookingAway)
        {
            isFirstTimeAfterLookingAway = false;

            yield return new WaitForSecondsRealtime(5.0f);

            isFirstTimeAfterLookingAway = true;
            isStunned = false;
        }
    }
}
