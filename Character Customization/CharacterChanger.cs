using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script is for the character customization scene.
/// Player will use mouse to select next/previous buttons and iterate through customization options.
/// Handles changes of a single sprite (examples: weapon, hair, facial hair).
/// </summary>

public class CharacterChanger : MonoBehaviour
{
    [Header("Sprite to Change")]
    public SpriteRenderer bodyPart;

    [Header("Sprites to Cycle Through")]
    public List<Sprite> options = new List<Sprite>();

    private int currentOption = 0;

    public void NextOption()
    {
        currentOption++;
        if(currentOption >= options.Count)
        {
            currentOption = 0; // Reset if cycled through entire list
        }
        bodyPart.sprite = options[currentOption];
    }

    public void PreviousOption()
    {
        currentOption --;
        if(currentOption <= 0)
        {
            currentOption = options.Count - 1; // Reset if cycled through entire list
        }
        bodyPart.sprite = options[currentOption];
    }
}
