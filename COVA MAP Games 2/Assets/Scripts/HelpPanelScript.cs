using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpPanelScript : MonoBehaviour
{
    public GameObject HelpPanel;
    public Timer TimerScript;

    void Start()  //Help panel starts inactive.
    {
        HelpPanel.SetActive(false);
    }

    public void OpenHelpPanel()  //Appears when the Help button is clicked. Timer is paused.
    {
        HelpPanel.SetActive(true);
        TimerScript.PauseGame();
    }

    public void Update()   //When the help panel is active and the user clicks anywhere, the help panel is set inactive and the timer resumes.
    {
        if (Input.GetMouseButtonDown(0) && HelpPanel.activeSelf == true)
        {
            HelpPanel.SetActive(false);
            TimerScript.ResumeGame();
        }
    }
}
