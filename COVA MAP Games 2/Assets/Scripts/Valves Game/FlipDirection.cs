using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum FlipState
{
    HighToLow,
    LowToHigh
}

public class FlipDirection : MonoBehaviour
{
    public FlipState flipindex = FlipState.HighToLow;

    public FlipState correctFlipIndex;

    public SpriteRenderer image;

    public Sprite highToLowSprite;
    public Sprite lowToHighSprite;

    // Start is called before the first frame update
    public void FlipDirectionButton()
    {

        if (flipindex == FlipState.HighToLow)
        {
            flipindex = FlipState.LowToHigh;
        }
        else
        {
            flipindex = FlipState.HighToLow;
        }
    }

    private void Update()
    {
        if (flipindex == FlipState.HighToLow)
        {
            image.sprite = highToLowSprite;
        }
        else if (flipindex == FlipState.LowToHigh)
        {
            image.sprite = lowToHighSprite;
        }
    }
}
