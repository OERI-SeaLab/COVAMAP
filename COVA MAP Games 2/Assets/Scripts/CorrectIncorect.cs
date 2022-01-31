using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Assign the needed sprite (incorrect or correct) to the image.

public class CorrectIncorect : MonoBehaviour
{
    public Sprite[] CorrectIncorrectSprites;
    public Image Indicator;

    public void AssignCorrect()
    {
        Indicator.sprite = CorrectIncorrectSprites[1];
    }

    public void AssignIncorrect()
    {
        Indicator.sprite = CorrectIncorrectSprites[0];
    }
}
