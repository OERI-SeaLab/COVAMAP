using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScenarioButton : MonoBehaviour
{
    // load the scoreboard for the valves game when the next button is clicked
    public void NextButtonNextScenario()
    {
        SceneManager.LoadScene("ScoreboardValves");
    }
}
