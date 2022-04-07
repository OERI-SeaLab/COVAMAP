using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreElectrical : MonoBehaviour
{
    public Text text;

    public void Start()
    {
        DontDestroy.ScenarioCounter = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if (DontDestroy.ScenarioCounter == 1)
        {
            text.text = "Score: 0";
        }
        if (DontDestroy.ScenarioCounter == 2)
        {
            text.text = "Score: 12.5" ;
        }
        if (DontDestroy.ScenarioCounter == 3)
        {
            text.text = "Score: 25";
        }
        if (DontDestroy.ScenarioCounter == 4)
        {
            text.text = "Score: 37.5";
        }
        if (DontDestroy.ScenarioCounter == 5)
        {
            text.text = "Score: 50";
        }
        if (DontDestroy.ScenarioCounter == 6)
        {
            text.text = "Score: 62.5";
        }
        if (DontDestroy.ScenarioCounter == 7)
        {
            text.text = "Score: 75";
        }
        if (DontDestroy.ScenarioCounter == 8)
        {
            text.text = "Score: 77.5";
        }

        
    }
}
