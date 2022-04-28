using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Randomly chooses another scenario from the scenario list and then loads the PPE scene again. If there are no scenarios left, only the quit button is displayed. 

public class NewScenarioPPE : MonoBehaviour
{
        
        public GameObject NewScenarioButtonPanel;  
        public CSV CSVScript;

        public void Start()
        {

            DontDestroy.CorrectList.Clear();

            DontDestroy.ScenarioList.Remove(DontDestroy.ScenarioChoice);   //Remove the used scenario.
            DontDestroy.InstructionsList.Remove(DontDestroy.InstructionsText);

            if(DontDestroy.ScenarioList.Count == 0)   //If there are no scenarios left, hide the next scenario button.
            {
                NewScenarioButtonPanel.SetActive(false);
            }
        }
        
        private int index;

        public void PickNewScenario()
        {  

        if(DontDestroy.ScenarioList.Count > 0)   //If there are scenarios left, pick a new one and reload the PPE Game scene.
        {
            index = Random.Range(0, DontDestroy.ScenarioList.Count - 1);
            DontDestroy.ScenarioChoice = DontDestroy.ScenarioList[index];
            DontDestroy.InstructionsText = DontDestroy.InstructionsList[index];
            DontDestroy.ScenarioReminderText = CSV.Find_id(DontDestroy.ScenarioChoice).scenario;

        DontDestroy.CorrectList.Add(CSV.Find_id(DontDestroy.ScenarioChoice).head);    //Create CheckList with the correct answers from the csv.
        DontDestroy.CorrectList.Add(CSV.Find_id(DontDestroy.ScenarioChoice).eyes);
        DontDestroy.CorrectList.Add(CSV.Find_id(DontDestroy.ScenarioChoice).ears);
        DontDestroy.CorrectList.Add(CSV.Find_id(DontDestroy.ScenarioChoice).face);
        DontDestroy.CorrectList.Add(CSV.Find_id(DontDestroy.ScenarioChoice).top);
        DontDestroy.CorrectList.Add(CSV.Find_id(DontDestroy.ScenarioChoice).hands);
        DontDestroy.CorrectList.Add(CSV.Find_id(DontDestroy.ScenarioChoice).bottom);
        DontDestroy.CorrectList.Add(CSV.Find_id(DontDestroy.ScenarioChoice).feet);
        DontDestroy.CorrectList.Add(CSV.Find_id(DontDestroy.ScenarioChoice).accessories);


            Debug.Log(DontDestroy.ScenarioChoice);

            SceneManager.LoadScene("PPE");
        }

        }

}
