using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// This script allows the player to quit the fishing game and return the the main world when
/// the "Return to World" button is mouse-clicked.
/// </summary>

public class ReturnToWorld : MonoBehaviour
{
    public void ReturnToHomeBase()
    {
        SceneManager.LoadScene(0); // Loads the homebase
    }
}
