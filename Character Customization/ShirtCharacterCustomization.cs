using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script is for the character customization scene.
/// Player will use mouse to select next/previous buttons and iterate through customization options.
/// Handles changes of shirts, which is a multi-sprite character option (left arm, right arm, and torso have separate sprites).
/// </summary>

public class ShirtCharacterCustomization : MonoBehaviour
{
    [Header("Sprite to Change")]
    public SpriteRenderer torso;
    public SpriteRenderer leftArm;
    public SpriteRenderer rightArm;

    [Header("Sprites to Cycle Through")]
    public List<Sprite> torsoOptions = new List<Sprite>();
    public List<Sprite> leftArmOptions = new List<Sprite>();
    public List<Sprite> rightArmOptions = new List<Sprite>();

    private int currentOption = 0;

    public void NextOption()
    {
        currentOption++;
        if (currentOption >= torsoOptions.Count)
        {
            currentOption = 0; // Reset if cycled through entire list
        }
        torso.sprite = torsoOptions[currentOption];
        leftArm.sprite = leftArmOptions[currentOption];
        rightArm.sprite = rightArmOptions[currentOption];
    }

    public void PreviousOption()
    {
        currentOption--;
        if (currentOption <= 0)
        {
            currentOption = torsoOptions.Count - 1; // Reset if cycled through entire list
        }
        torso.sprite = torsoOptions[currentOption];
        leftArm.sprite = leftArmOptions[currentOption];
        rightArm.sprite = rightArmOptions[currentOption];
    }
}
