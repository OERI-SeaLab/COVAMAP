using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameScenarioInfoPanels : MonoBehaviour
{
    public GameObject AboutText;  //About the game text.
    public GameObject AboutTextPanel;   //About the game panel (can be hidden).
    public Timer TimerScript;  //Referencing timer script.
    public ReadyToPlayAudio ReadyToPlayAudioScript;
    public GameObject ScenarioText;
    public GameObject ScenarioReminderText;

    private void Awake()
    {
        if (DontDestroy.GameChoice == "PPE" || DontDestroy.GameChoice == "Valves")
        {
            TimerScript.PauseGame();  //Game starts paused until the scenario instructions are read and the user proceeds to the game.
        }
    }
    void Start()
    {
        if (DontDestroy.GameChoice == "PPE" || DontDestroy.GameChoice == "Valves")
        {
            AboutText.GetComponent<Text>().text = DontDestroy.InstructionsText;  //Pull scenario instructions text that was saved to the DoNotDestroy script.
        }

        DontDestroy.ScenarioCounter = DontDestroy.ScenarioCounter + 1;
        

        if (DontDestroy.GameChoice == "PPE")
        {
            ScenarioText.GetComponent<Text>().text = "Scenario: " + DontDestroy.ScenarioCounter + "/5";
            ScenarioReminderText.GetComponent<Text>().text = "Dressing for " + DontDestroy.ScenarioReminderText + ".";
        }

        if (DontDestroy.GameChoice == "Valves")
        {
            ScenarioText.GetComponent<Text>().text = "Scenario: " + DontDestroy.ScenarioCounter + "/4";
        }

        if (DontDestroy.GameChoice == "Hazards")
        {
            ScenarioText.GetComponent<Text>().text = "Scenario: " + DontDestroy.ScenarioCounter + "/11";
        }
    }

    public void Update()
    {
        if (DontDestroy.GameChoice == "PPE" || DontDestroy.GameChoice == "Valves")
        {


            if (Input.GetMouseButtonDown(0) && AboutTextPanel.activeSelf == true)
            {
                AboutTextPanel.SetActive(false);  //Set the panel with the scenario text inactive.

                if (DontDestroy.GameChoice == "PPE" || DontDestroy.GameChoice == "Valves")
                {
                    ReadyToPlayAudioScript.ReadyToPlay();
                }

            }
        }
    }


}
