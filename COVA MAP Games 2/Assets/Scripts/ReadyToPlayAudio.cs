using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadyToPlayAudio : MonoBehaviour
{

    public AudioSource ReadyToStartGame;
    public AudioSource GoSound;
    //public AudioSource GoAudio;
    public AudioSource InGameMusic;

    public Timer TimerScript;  //Referencing timer script.

    public GameObject CountdownPanel;
    public GameObject CountdownNumber1;
    public GameObject CountdownNumber2;
    public GameObject CountdownNumber3;
    public GameObject CountdownNumberGo;

    private void Start()
    {
        if (DontDestroy.GameChoice == "PPE" || DontDestroy.GameChoice == "Valves" || DontDestroy.GameChoice == "Electrical")
        {
            CountdownPanel.SetActive(false);
            CountdownNumber1.SetActive(false);
            CountdownNumber2.SetActive(false);
            CountdownNumber3.SetActive(false);
            CountdownNumberGo.SetActive(false);
        }
        if (DontDestroy.GameChoice == "Hazards")
        {
            StopBackGroundMusic();
            InGameMusic.Play();
        }
    }
    public void ReadyToPlay()
    {
        StopBackGroundMusic();

        if (DontDestroy.GameChoice == "PPE" || DontDestroy.GameChoice == "Valves" || DontDestroy.GameChoice == "Electrical")
        {
            StartCoroutine(CountDownDelay());
        }
        
    }

    public void StopBackGroundMusic()
    {
        GameObject.FindGameObjectWithTag("Music").GetComponent<PlayAudio>().StopMusic();
    }

    public IEnumerator CountDownDelay()
    {
        print("start delay countdown");

        CountdownPanel.SetActive(true);

        if (DontDestroy.GameChoice == "PPE" || DontDestroy.GameChoice == "Valves" || DontDestroy.GameChoice == "Electrical")
        {
            if (DontDestroy.ScenarioCounter == 1)
            {
                yield return new WaitForSecondsRealtime(1);
                CountdownNumber3.SetActive(true);
                ReadyToStartGame.Play();
                yield return new WaitForSecondsRealtime(1);
                CountdownNumber3.SetActive(false);
                CountdownNumber2.SetActive(true);
                ReadyToStartGame.Play();
                yield return new WaitForSecondsRealtime(1);
                CountdownNumber2.SetActive(false);
                CountdownNumber1.SetActive(true);
                ReadyToStartGame.Play();
                yield return new WaitForSecondsRealtime(1);
                CountdownNumber1.SetActive(false);
            }

            CountdownNumberGo.SetActive(true);
            GoSound.Play();
            InGameMusic.Play();
            yield return new WaitForSecondsRealtime(1);
            CountdownNumberGo.SetActive(false);
            CountdownPanel.SetActive(false);

        }

        
        //GoAudio.Play();
        TimerScript.ResumeGame();   //Game starts paused until the scenario instructions are read and the user proceeds to the game.
    }
}
