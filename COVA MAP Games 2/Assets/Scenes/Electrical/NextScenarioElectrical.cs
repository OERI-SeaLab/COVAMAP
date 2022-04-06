using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextScenarioElectrical : MonoBehaviour
{

    public Image hard;
    public Image medium;
    public Image easy;
    public GameObject NextButtonPanel;

    public void Start()
    {
        print("the scenario is: " + DontDestroy.ScenarioCounter);
        //DontDestroy.ScenarioCounter = 1;

        foreach (GameObject go in ScenarioImages)
        {
            go.SetActive(false);
        }

        ScenarioImages[0].SetActive(true);
    }


    public List<GameObject> ScenarioImages = new List<GameObject>();

    // Start is called before the first frame update
    public void NextButtonNextScenario()
    {

        DontDestroy.ScenarioCounter++;

        print("the scenario is: " + DontDestroy.ScenarioCounter);

        foreach (GameObject go in ScenarioImages)
        {
            go.SetActive(false);
        }

        if (DontDestroy.ScenarioCounter==1)
        {
            ScenarioImages[0].SetActive(true);
        }
        if (DontDestroy.ScenarioCounter == 2)
        {
            ScenarioImages[1].SetActive(true);
        }
        if (DontDestroy.ScenarioCounter == 3)
        {
            ScenarioImages[2].SetActive(true);
        }
        if (DontDestroy.ScenarioCounter == 4)
        {
            ScenarioImages[3].SetActive(true);
        }
        if (DontDestroy.ScenarioCounter == 5)
        {
            ScenarioImages[4].SetActive(true);
        }
        if (DontDestroy.ScenarioCounter == 6)
        {
            ScenarioImages[5].SetActive(true);
        }
        if (DontDestroy.ScenarioCounter == 7)
        {
            ScenarioImages[6].SetActive(true);
        }
        if (DontDestroy.ScenarioCounter == 8)
        {
            ScenarioImages[7].SetActive(true);
        }
        if (DontDestroy.ScenarioCounter == 9)
        {
            DontDestroy.ElectricalWon = true;
            SceneManager.LoadScene("ScoreboardElectrical");
        }

        if (DontDestroy.LevelChoice == "Easy")
        {
            DontDestroy.timeLeft = 30.0f;
            easy.enabled = true;
            medium.enabled = true;
            hard.enabled = true;
        }

        if (DontDestroy.LevelChoice == "Medium")
        {
            DontDestroy.timeLeft = 20.0f;
            easy.enabled = false;
            medium.enabled = true;
            hard.enabled = true;
        }

        if (DontDestroy.LevelChoice == "Hard")
        {
            DontDestroy.timeLeft = 10.0f;
            easy.enabled = false;
            medium.enabled = false;
            hard.enabled = true;
        }

        NextButtonPanel.SetActive(false);

    }
}
