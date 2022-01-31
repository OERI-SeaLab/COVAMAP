using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollingValves : MonoBehaviour
{
    public GameObject[] ValveList;
    public int index;
    // public GameObject selected;
    public GameObject image;
    //public Sprite[] ValveListSprite;

    private void Start()
    {
        //Toggle off their renderer
        foreach (GameObject go in ValveList)
            go.SetActive(false);

        // Toggle on the selected
        if (ValveList[index])
            ValveList[index].SetActive(true);
    }

    public void ToggleLeftValve()  //Left buttons
    {
        // toggle off the current model
        ValveList[index].SetActive(false);

        index--;
        if (index < 0)
            index = ValveList.Length - 1;

        // toggle on the new model
        ValveList[index].SetActive(true);
        //image.sprite = ValveListSprite[index];
    }

    public void ToggleRightValve()  //Right buttons
    {
        // toggle off the current model
        ValveList[index].SetActive(false);

        index++;
        if (index == ValveList.Length)
            index = 0;

        // toggle on the new model
        ValveList[index].SetActive(true);
        //image.sprite = ValveListSprite[index];
    }

}

