using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Help panel on the main menu.

public class HelpPanelButton : MonoBehaviour
{
    public GameObject HelpPanel; 

    public void HelpButton()
    {
        HelpPanel.SetActive(true);  //Open help menu.
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            HelpPanel.SetActive(false);  //Close help menu.
        }
    }
}
