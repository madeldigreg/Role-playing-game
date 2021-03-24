using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployObstacle : MonoBehaviour
{
    public GameObject logPrefab;
    public float respawnTime = 4.0f;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(logWave());
    }

    private void spawnLog()
    {
        // Add log obstacle to scene in random y position to the right of the screen
        GameObject log = Instantiate(logPrefab) as GameObject;
        log.transform.position = new Vector2(screenBounds.x * 1.2f, Random.Range(-screenBounds.y * 0.5f, screenBounds.y * 0.5f));
    }

    IEnumerator logWave()
    {
        // Spawn a new log in time-dependent manner
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnLog();
        }
    }
}
