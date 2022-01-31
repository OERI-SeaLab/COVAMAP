using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;


public class TogglesCheck : MonoBehaviour
{
    public List<Toggle> checkboxes;
    public int TogglesOn { get; private set; }
    public int TogglesOff { get; private set; }

    public List<string> ToggleOnOff;

    public void GetToggleList()
    {
        foreach (Toggle toggle in checkboxes)
        {
            // get an initial count of on/off
            if (toggle.isOn)
            {
                ToggleOnOff.Add("1");
            }
            else
            {
                ToggleOnOff.Add("0");
            }

        }
        foreach(string i in ToggleOnOff)
        {
            print(i);
        }
        foreach(string i in DontDestroy.CorrectHazardsList)
        {
            print(i);
        }



    }

    public void CheckMatch()
    {
        DontDestroy.NumberCorrect = 0;

        for (int i = 0; i < ToggleOnOff.Count; i++)
        {
            if (ToggleOnOff[i] != DontDestroy.CorrectHazardsList[i])
            {
                print("dont match");
            }

            else
            {
                DontDestroy.NumberCorrect++;
                print("DOOOO match");
            }
        }
         
    }
}