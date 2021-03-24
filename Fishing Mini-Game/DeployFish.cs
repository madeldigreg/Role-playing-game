using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployFish : MonoBehaviour
{
    // This script controls how often fish spawn on screen

    public GameObject fishPrefab;
    public float respawnTime = 4.0f;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(fishWave());
    }

    private void spawnFish()
    {
        // Add fish to scene in random y position to the right of the screen
        GameObject fish = Instantiate(fishPrefab) as GameObject;
        fish.transform.position = new Vector2(screenBounds.x * 1.2f, Random.Range(-screenBounds.y * 0.5f, screenBounds.y * 0.5f));
    }

    IEnumerator fishWave()
    {
        // Spawn a new fish in time-dependent manner
        while (true) {
            yield return new WaitForSeconds(respawnTime);
            spawnFish();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
