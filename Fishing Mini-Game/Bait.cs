using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bait : MonoBehaviour
{
    CastRod rod;

    void Start()
    {
        rod = GameObject.FindGameObjectWithTag("fishingRod").GetComponent<CastRod>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "fish")
        {
            rod.FishHit(collision.gameObject);
        }

        if(collision.gameObject.tag == "log")
        {
            rod.LogHit(collision.gameObject);
        }

        Destroy(gameObject);
    }
}
