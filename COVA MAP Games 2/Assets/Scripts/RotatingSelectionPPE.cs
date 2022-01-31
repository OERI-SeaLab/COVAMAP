using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotatingSelectionPPE : MonoBehaviour
{
    public GameObject[] PPEList;
    private int index=0;
    // public GameObject selected;
    public Image image;
    public Sprite[] PPEListSprite;

    private void Start()  
    {
        //Toggle off their renderer
         foreach(GameObject go in PPEList)
             go.SetActive(false);
   
       // Toggle on the selected
        if(PPEList[index])
            PPEList[index].SetActive(true);
    }

    public void ToggleLeft()  //Left buttons
    {
        // toggle off the current model
        PPEList[index].SetActive(false);

        index--;
        if(index < 0)
            index = PPEListSprite.Length -1;

        // toggle on the new model
        PPEList[index].SetActive(true);
        image.sprite = PPEListSprite[index];
    }

    public void ToggleRight()  //Right buttons
    {
        // toggle off the current model
        PPEList[index].SetActive(false);

        index++;
        if(index == PPEListSprite.Length)
            index = 0;

        // toggle on the new model
        PPEList[index].SetActive(true);
        image.sprite = PPEListSprite[index];
    }

}
