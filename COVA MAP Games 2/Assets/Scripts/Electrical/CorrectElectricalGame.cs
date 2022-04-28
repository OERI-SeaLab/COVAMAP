using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CorrectElectricalGame : MonoBehaviour
{


    public GameObject[] allWires;
    public GameObject[] allConnectors;
    public GameObject[] allDeleteButtons;
    public NextScenarioElectrical NextScenarioElectricalScript;
    public GameObject NextButtonPanel;




    // Start is called before the first frame update
    public void CorrectAnswer()
    {
        print("Correct Answer");


        for (int i = 0; i < allWires.Length; i++)
        {
            if(allWires[i].activeSelf)
            {
                allConnectors[i].GetComponent<BoxCollider>().enabled = false;
                allDeleteButtons[i].SetActive(false);
            }
        }

        

        NextButtonPanel.SetActive(true);

        DontDestroy.ElectricalWon = true;


    }
}
