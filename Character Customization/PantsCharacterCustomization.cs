using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script is for the character customization scene.
/// Player will use mouse to select next/previous buttons and iterate through customization options.
/// Handles changes of pants, which is a multi-sprite character option (left leg and right leg have separate sprites).
/// </summary>

public class PantsCharacterCustomization : MonoBehaviour
{
    [Header("Sprite to Change")]
    public SpriteRenderer leftLeg;
    public SpriteRenderer rightLeg;

    [Header("Sprites to Cycle Through")]
    public List<Sprite> leftLegOptions = new List<Sprite>();
    public List<Sprite> rightLegOptions = new List<Sprite>();

    private int currentOption = 0;

    public void NextOption()
    {
        currentOption++;
        if (currentOption >= leftLegOptions.Count)
        {
            currentOption = 0; // Reset if cycled through entire list
        }
        leftLeg.sprite = leftLegOptions[currentOption];
        rightLeg.sprite = rightLegOptions[currentOption];
    }

    public void PreviousOption()
    {
        currentOption--;
        if (currentOption <= 0)
        {
            currentOption = leftLegOptions.Count - 1; // Reset if cycled through entire list
        }
        leftLeg.sprite = leftLegOptions[currentOption];
        rightLeg.sprite = rightLegOptions[currentOption];
    }
}
