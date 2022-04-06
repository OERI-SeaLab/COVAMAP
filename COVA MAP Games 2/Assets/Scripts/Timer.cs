using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Timer : MonoBehaviour

{
    public Text text;   //Timer text.
    public float time = 0.0f;
    //public float timeLeft = 0.0f;

    //Referencing other scripts.
    public CheckAnswersPPE CheckAnswersPPEScript;  
    public ScoringPPE ScoringPPEScript;
    public CheckAnswers CheckAnswersElectricalScript;

    public GameObject NextButtonPanel; 
    public GameObject CheckButtonPanel;
    public GameObject AboutValvePanel;
    public GameObject[] LeftRightButtons;  //Array of the buttons that allow the user to switch between PPE.

    public Image hard;
    public Image medium;
    public Image easy;

    public Color redColor = Color.red;
    public float redTime = 10.0f; // Seconds to start turning text red
    public float flashRedTime = 5.0f; // Seconds to start turning text red
    public float flashRedSpeed = 3.0f;

    Color initialColor;
    public AudioSource TimeRunningOutSound;

    int timeSecond;
    int lastTimeSecond;




    public void Start()
    {
        time = 20.0f;
        
        if (DontDestroy.GameChoice=="Electrical")
        {
            time = 10.0f;
        }
        
        if (DontDestroy.GameChoice == "Hazards")
        {
            time = 5.0f;
            Time.timeScale = 1;
        }
        

        initialColor = text.color;

        if (DontDestroy.GameChoice == "PPE" || DontDestroy.GameChoice == "Electrical")
        {
            CheckButtonPanel.SetActive(true);   //Check button is active to start. Will disappear when time runs out.
        }

        if (DontDestroy.GameChoice == "Valves")
        {
            CheckButtonPanel.SetActive(false);   //Check button is active to start. Will disappear when time runs out.
        }

        if (DontDestroy.GameChoice == "PPE" || DontDestroy.GameChoice == "Valves" || DontDestroy.GameChoice == "Electrical")
        {
            NextButtonPanel.SetActive(false);    //Next button is inactive to start. Will appear when time runs out.
        }



        if (DontDestroy.GameChoice == "PPE")
        {
            foreach (GameObject x in LeftRightButtons)  //All the buttons that allow the user to switch between PPE are active to start. Will disappear when time runs out.
            {
                x.SetActive(true);
            }
        }


        //Choose time allowed based on level choice.

        if (DontDestroy.GameChoice == "PPE" || DontDestroy.GameChoice == "Valves")
        {
            if (DontDestroy.LevelChoice == "Easy")
            {
                DontDestroy.timeLeft = 60.0f;
            }


            else if (DontDestroy.LevelChoice == "Medium")
            {
                DontDestroy.timeLeft = 40.0f;
                easy.enabled = false;
            }

            else if (DontDestroy.LevelChoice == "Hard")
            {
                DontDestroy.timeLeft = 20.0f;  //To be changed back to 20.0
                easy.enabled = false;
                medium.enabled = false;
            }
        }

        if ( DontDestroy.GameChoice == "Hazards")
        {
            if (DontDestroy.LevelChoice == "Easy" )
            {
                DontDestroy.timeLeft = 15.0f;
                easy.enabled = false;
                medium.enabled = false;
                hard.enabled = false;
            }

            else if (DontDestroy.LevelChoice == "Medium" )
            {
                DontDestroy.timeLeft = 10.0f;
                easy.enabled = false;
                medium.enabled = false;
                hard.enabled = false;
            }

            else if (DontDestroy.LevelChoice == "Hard" )
            {
                DontDestroy.timeLeft = 5.0f;
                easy.enabled = false;
                medium.enabled = false;
                hard.enabled = false;
            }
        }

        if (DontDestroy.GameChoice == "Electrical")
        {
            if (DontDestroy.LevelChoice == "Easy" )
            {
                DontDestroy.timeLeft = 30.0f;
                easy.enabled = true;
                medium.enabled = true;
                hard.enabled = true;
            }

            else if (DontDestroy.LevelChoice == "Medium" )
            {
                DontDestroy.timeLeft = 20.0f;
                easy.enabled = false;
                medium.enabled = true;
                hard.enabled = true;
            }

            else if (DontDestroy.LevelChoice == "Hard" )
            {
                DontDestroy.timeLeft = 10.0f;
                easy.enabled = false;
                medium.enabled = false;
                hard.enabled = true;
            }
        }
        //Specific to Hazards game

    }

    bool Checked = false;  //Bool need to use as a condition to stop the update method.

    public void Update()  //Timer counts down in seconds.
    { 

        if (Time.timeSinceLevelLoad > 0.1f && DontDestroy.GameChoice == "Hazards")
        {
            DontDestroy.timeLeft -= Time.deltaTime;
            if (DontDestroy.timeLeft <= 5.0f)
            {
                hard.fillAmount -= 1.0f / time * Time.deltaTime;
            }

            if (DontDestroy.timeLeft <= 10.0f)
            {
                medium.fillAmount -= 1.0f / time * Time.deltaTime;
            }

            if (DontDestroy.timeLeft <= 15.0f)
            {
                easy.fillAmount -= 1.0f / time * Time.deltaTime;
            }
        }

        if (Time.timeSinceLevelLoad > 0.1f && DontDestroy.GameChoice == "Valves")
        {
            DontDestroy.timeLeft -= Time.deltaTime;
            if (DontDestroy.timeLeft <= 20.0f)
            {
                hard.fillAmount -= 1.0f / time * Time.deltaTime;
            }

            if (DontDestroy.timeLeft <= 40.0f)
            {
                medium.fillAmount -= 1.0f / time * Time.deltaTime;
            }

            if (DontDestroy.timeLeft <= 60.0f)
            {
                easy.fillAmount -= 1.0f / time * Time.deltaTime;
            }
        }

        if (Time.timeSinceLevelLoad > 0.1f && DontDestroy.GameChoice == "PPE")
        {
            DontDestroy.timeLeft -= Time.deltaTime;
            if (DontDestroy.timeLeft <= 20.0f)
            {
                hard.fillAmount -= 1.0f / time * Time.deltaTime;
            }

            if (DontDestroy.timeLeft <= 40.0f)
            {
                medium.fillAmount -= 1.0f / time * Time.deltaTime;
            }

            if (DontDestroy.timeLeft <= 60.0f)
            {
                easy.fillAmount -= 1.0f / time * Time.deltaTime;
            }
        }

        if (Time.timeSinceLevelLoad > 0.1f && DontDestroy.GameChoice == "Electrical")
        {
            DontDestroy.timeLeft -= Time.deltaTime;
            if (DontDestroy.timeLeft <= 10.0f)
            {
                hard.fillAmount -= 1.0f / time * Time.deltaTime;
            }

            if (DontDestroy.timeLeft <= 20.0f)
            {
                medium.fillAmount -= 1.0f / time * Time.deltaTime;
            }

            if (DontDestroy.timeLeft <= 30.0f)
            {
                easy.fillAmount -= 1.0f / time * Time.deltaTime;
            }
        }


        timeSecond = Mathf.CeilToInt(DontDestroy.timeLeft);

        text.text = "" + timeSecond;
        //print(DontDestroy.timeLeft);
        
        if(DontDestroy.timeLeft < 5 && lastTimeSecond != 1) 
        {
            if (timeSecond != lastTimeSecond)
            {
                TimeRunningOutSound.Play();
                lastTimeSecond = timeSecond;
            }
        }

        // Flashing stuff done by Cal
        if (DontDestroy.timeLeft < redTime)
        {
            text.color = redColor;

            if (DontDestroy.timeLeft < flashRedTime)
            {
                text.color = ((Time.time * flashRedSpeed % 1) < 0.5f) ? Color.clear : redColor;

            }
        }
        else
        {
            text.color = initialColor;
        }

        

        if (DontDestroy.timeLeft < 0 && Checked == false )  //When time runs out and checked = false...
        {
            PauseGame();
            if (DontDestroy.GameChoice == "PPE")
            {
                CheckAnswersPPEScript.CheckingAnswers();
                Checked = true;  //So that the if condition is not met again.
                CheckButtonPanel.SetActive(false);  //Hide check button.
                NextButtonPanel.SetActive(true);   //Show Next button.
                foreach (GameObject x in LeftRightButtons)  //Make the buttons that allow the user to switch between PPE inactive.
                {
                    x.SetActive(false);
                }
            }

            if (DontDestroy.GameChoice == "Valves")
            {
                //CheckAnswersPPEScript.CheckingAnswers();
                Checked = true;  //So that the if condition is not met again.
                AboutValvePanel.SetActive(false);
                CheckButtonPanel.SetActive(false);
                DontDestroy.NumberCorrect = 0;
            }

            if (DontDestroy.GameChoice == "Hazards")
            {
                //CheckAnswersPPEScript.CheckingAnswers();
                Checked = true;  //So that the if condition is not met again.
                DontDestroy.NumberCorrect = 0;
                SceneManager.LoadScene("HazardsChecklist");
            }
            if (DontDestroy.GameChoice == "Electrical")
            {
                CheckAnswersElectricalScript.CheckAnswerElectrical();          
                //Checked = true;  //So that the if condition is not met again.
                //CheckButtonPanel.SetActive(false);  //Hide check button.
                NextButtonPanel.SetActive(true);   //Show Next button.
            }
        }
    }


    public void PauseGame()  //Pause game and timer. Used when instructions are displayed, the help menu is active, and when the time runs out.
    {
        Time.timeScale = 0;
    }

    public void ResumeGame()  //REsume game and timer.
    {
        Time.timeScale = 1;
    }
}
