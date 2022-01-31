using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lives : MonoBehaviour
{
    public Timer TimerScript;

    public GameObject NextButtonPanel;
    
    public GameObject Life1;
    public GameObject Life2;
    public GameObject Life3;


    public int index = 0;
    public List<GameObject> ValveGuessingAnswers;
    public List<GameObject> ValveGuessingAnswers1;
    public List<GameObject> ValveGuessingAnswers2;
    public List<GameObject> ValveGuessingAnswers3;
    public List<GameObject> ValveGuessingAnswers4;
    public List<GameObject> ValveGuessingAnswers5;

    public List<GameObject> DisappearAtEnd;



    // Start is called before the first frame update
    void Start()
    {
        DontDestroy.NumberTimesChecked = 0;
        Life1.SetActive(true);
        Life2.SetActive(true);
        Life3.SetActive(true);
        print("Number of times checked: " + DontDestroy.NumberTimesChecked);


        if (DontDestroy.ScenarioChoice == "1")
        {
            ValveGuessingAnswers = ValveGuessingAnswers1;
        }

        if (DontDestroy.ScenarioChoice == "2")
        {
            ValveGuessingAnswers = ValveGuessingAnswers2;
        }

        if (DontDestroy.ScenarioChoice == "3")
        {
            ValveGuessingAnswers = ValveGuessingAnswers3;
        }

        if (DontDestroy.ScenarioChoice == "4")
        {
            ValveGuessingAnswers = ValveGuessingAnswers4;
        }

        if (DontDestroy.ScenarioChoice == "5")
        {
            ValveGuessingAnswers = ValveGuessingAnswers5;
        }

        foreach (GameObject x in ValveGuessingAnswers)
        {
            x.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (DontDestroy.NumberTimesChecked == 1)
        {
            Life3.SetActive(false);
        }
        if (DontDestroy.NumberTimesChecked == 2)
        {
            Life2.SetActive(false);
        }
        if (DontDestroy.NumberTimesChecked == 3)
        {
            Life1.SetActive(false);
            if (DontDestroy.CaughtGuessing == false)
            {
                Guessing();
                DontDestroy.CaughtGuessing = true;
            }
        }
    }


    public void Guessing()
    {
        TimerScript.PauseGame();

        NextButtonPanel.SetActive(true);

        foreach (GameObject x in DisappearAtEnd)
        {
            x.SetActive(false);
        }

        foreach (int x in DontDestroy.NumberTimesCheckedPerValveArray)
        {
            print("THE LIST: " + x);
            if (x >= 2)
            {
                print("index: " + index + " is guessing....");
                ValveGuessingAnswers[index].SetActive(true);
                
            }

            index = index + 1;
        }
    }
}
