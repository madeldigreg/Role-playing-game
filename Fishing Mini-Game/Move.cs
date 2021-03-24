using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // This script controls fish swimming behaviour in the homebase fishing minigame

    public float swimSpeed = 1f;
    private Rigidbody2D fishRB;


    // Start is called before the first frame update
    void Start()
    {
        fishRB = this.GetComponent<Rigidbody2D>();
        fishRB.velocity = new Vector2(-swimSpeed, 0);
    }

    private void OnCollisionEnter2D(Collision2D otherObj)
    {
        // destroy fish and logs off screen
        if (otherObj.gameObject.CompareTag("Finish"))
            {
            Destroy(gameObject);
            }

        // if fish is caught
        if (otherObj.gameObject.CompareTag("fishCaught"))
        {
            FishingScore.scoreValue += 10;
            Destroy(gameObject);
        }

        // if fish collides with log
        if (otherObj.gameObject.CompareTag("log"))
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
