using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScenarioButton : MonoBehaviour
{
    public void NextButtonNextScenario()
    {
        SceneManager.LoadScene("ScoreboardValves");
    }
}
