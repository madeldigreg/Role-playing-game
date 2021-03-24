using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script is for the character customization scene.
/// Player will use mouse to select next/previous buttons and iterate through customization options.
/// Handles changes of skin tone, which is a multi-sprite character option (face, left/right arms, left/right legs).
/// </summary>

public class SkinToneCharacterCustomization : MonoBehaviour
{
    [Header("Sprite to Change")]
    public SpriteRenderer leftArm;
    public SpriteRenderer rightArm;
    public SpriteRenderer body;
    public SpriteRenderer leftFoot;
    public SpriteRenderer rightFoot;
    public SpriteRenderer head;

    [Header("Sprites to Cycle Through")]
    public List<Sprite> leftArmOptions = new List<Sprite>();
    public List<Sprite> rightArmOptions = new List<Sprite>();
    public List<Sprite> bodyOptions = new List<Sprite>();
    public List<Sprite> leftFootOptions = new List<Sprite>();
    public List<Sprite> rightFootOptions = new List<Sprite>();
    public List<Sprite> headOptions = new List<Sprite>();

    private int currentOption = 0;

    public void NextOption()
    {
        currentOption++;
        if (currentOption >= leftArmOptions.Count)
        {
            currentOption = 0; // Reset if cycled through entire list
        }
        leftArm.sprite = leftArmOptions[currentOption];
        rightArm.sprite = rightArmOptions[currentOption];
        body.sprite = bodyOptions[currentOption];
        leftFoot.sprite = leftFootOptions[currentOption];
        leftFoot.sprite = rightFootOptions[currentOption];
        head.sprite = headOptions[currentOption];
    }

    public void PreviousOption()
    {
        currentOption--;
        if (currentOption <= 0)
        {
            currentOption = leftArmOptions.Count - 1; // Reset if cycled through entire list
        }
        leftArm.sprite = leftArmOptions[currentOption];
        rightArm.sprite = rightArmOptions[currentOption];
        body.sprite = bodyOptions[currentOption];
        leftFoot.sprite = leftFootOptions[currentOption];
        leftFoot.sprite = rightFootOptions[currentOption];
        head.sprite = headOptions[currentOption];
    }
}
