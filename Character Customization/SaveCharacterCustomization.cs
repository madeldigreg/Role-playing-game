using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// This script saves the player's customization changes and returns the scene to the homebase.
/// </summary>

public class SaveCharacterCustomization : MonoBehaviour
{
    public GameObject character;

    public void Submit()
    {
        PrefabUtility.SaveAsPrefabAsset(character, "Assets/Player.prefab"); // Saves the player's sprite selections
        SceneManager.LoadScene(0); // Loads the homebase
    }


}
