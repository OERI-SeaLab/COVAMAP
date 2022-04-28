using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCorrectScenario : MonoBehaviour
{
    // Show correct instructions based on the current scenario

    public GameObject Scenario1Panel;
    public GameObject Scenario2Panel;
    public GameObject Scenario3Panel;
    public GameObject Scenario4Panel;

    public void DisplayCorrectScenario()
    {
        if(DontDestroy.ScenarioChoice=="1")
        {
            print("Diplaying panel 1");
            Scenario1Panel.SetActive(true);
            Scenario2Panel.SetActive(false);
            Scenario3Panel.SetActive(false);
            Scenario4Panel.SetActive(false);
        }
        if (DontDestroy.ScenarioChoice == "2")
        {
            print("Diplaying panel 2");
            Scenario1Panel.SetActive(false);
            Scenario2Panel.SetActive(true);
            Scenario3Panel.SetActive(false);
            Scenario4Panel.SetActive(false);
        }
        if (DontDestroy.ScenarioChoice == "3")
        {
            print("Diplaying panel 3");
            Scenario1Panel.SetActive(false);
            Scenario2Panel.SetActive(false);
            Scenario3Panel.SetActive(true);
            Scenario4Panel.SetActive(false);
        }
        if (DontDestroy.ScenarioChoice == "4")
        {
            print("Diplaying panel 4");
            Scenario1Panel.SetActive(false);
            Scenario2Panel.SetActive(false);
            Scenario3Panel.SetActive(false);
            Scenario4Panel.SetActive(true);
        }
    }

}
