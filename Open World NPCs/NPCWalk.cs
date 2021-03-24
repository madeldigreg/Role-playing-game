using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script controls non-playable character (NPC) walking behaviour.
/// Certain NPCs will wander back and forth at the homebase.
/// </summary>

public class NPCWalk : MonoBehaviour
{
    public float paceSpeed;
    Rigidbody2D rb;
    public float timer;
    public float directionx;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(Move(timer));
    }
    IEnumerator Move(float timer)
    {
        while (true)
        {
            Vector2 targetVelocity = new Vector2(directionx, 0);
            GetComponent<SpriteRenderer>().flipX = true;
            rb.velocity = targetVelocity * paceSpeed;
            yield return new WaitForSeconds(timer);

            Vector2 targetVelocity1 = new Vector2(-directionx, 0);
            GetComponent<SpriteRenderer>().flipX = false;
            rb.velocity = targetVelocity1 * paceSpeed;
            yield return new WaitForSeconds(timer);
            //yield break;
        }
    }
}
