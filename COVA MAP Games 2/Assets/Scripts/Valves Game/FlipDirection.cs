using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Flip the valves when a directional flip btton is pushed
public enum FlipState
{
    HighToLow,  //high pressure to low pressure
    LowToHigh  //low pressure to high pressure
}

public class FlipDirection : MonoBehaviour
{
    public FlipState flipindex = FlipState.HighToLow;

    public FlipState correctFlipIndex;

    public SpriteRenderer image;

    public Sprite highToLowSprite;
    public Sprite lowToHighSprite;

    // flip the direction
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

    //show correct positioning of the valve depending on selected flipstate
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
