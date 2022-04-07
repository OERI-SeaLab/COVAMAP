using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour
{

    public Text ScoreText;

    //PPE
    public Text CongratsText;
    public Text FailText;

    //Valves
    public Text FailOutOfTimeText;
    public Text FailDirectionsText;
    public Text FailTooManyTriesText;


    public float TimeBonus = 0.0f;
    public Text TimeBonusText;
    public float TotalScoreWithTimeBonus = 0.0f;
    public GameObject TimeBonusGameObject;

    public AudioSource CongratsAudio;
    public AudioSource FailAudio;
    public AudioSource TimeBonusAudio;



    public void Start()
    {

        TimeBonusGameObject.gameObject.SetActive(false);
        CongratsText.gameObject.SetActive(false);

        if ((DontDestroy.GameChoice == "Electrical") && (DontDestroy.ElectricalWon == false))
        {
            print("fail");
            CongratsText.gameObject.SetActive(false);
            FailText.gameObject.SetActive(true);
            FailAudio.Play();
        }

        if ((DontDestroy.GameChoice == "Electrical") && (DontDestroy.ElectricalWon == true))
        {

            print("correct!");
            CongratsText.gameObject.SetActive(true);
            FailText.gameObject.SetActive(false);
            CongratsAudio.Play();
        }

        if (DontDestroy.GameChoice=="PPE" || DontDestroy.GameChoice == "Hazards")
        {
            FailText.gameObject.SetActive(false);
        }

        if (DontDestroy.GameChoice == "Valves")
        {
            FailOutOfTimeText.gameObject.SetActive(false);
            FailDirectionsText.gameObject.SetActive(false);
            FailTooManyTriesText.gameObject.SetActive(false);
        }







        Time.timeScale = 1;

        if (DontDestroy.GameChoice == "PPE")
        {
            print(DontDestroy.timeLeft);

            if (DontDestroy.LevelChoice == "Hard" && DontDestroy.NumberCorrect == 9)
            {
                TimeBonus = 55.0f;

                ScoreText.text = "Your Score: " + DontDestroy.Score;
                StartCoroutine(GetScoreWithBonus());

            }

            if (DontDestroy.LevelChoice == "Medium" && DontDestroy.NumberCorrect == 9 && DontDestroy.timeLeft >= 20.0)
            {
                TimeBonus = 55.0f;
                ScoreText.text = "Your Score: " + DontDestroy.Score;
                StartCoroutine(GetScoreWithBonus());
            }

            if (DontDestroy.LevelChoice == "Medium" && DontDestroy.NumberCorrect == 9 && DontDestroy.timeLeft < 20.0)
            {
                TimeBonus = 45.0f;
                ScoreText.text = "Your Score: " + DontDestroy.Score;
                StartCoroutine(GetScoreWithBonus());
            }

            if (DontDestroy.LevelChoice == "Easy" && DontDestroy.NumberCorrect == 9 && DontDestroy.timeLeft >= 40.0)
            {
                TimeBonus = 55.0f;
                ScoreText.text = "Your Score: " + DontDestroy.Score;
                StartCoroutine(GetScoreWithBonus());
            }

            if (DontDestroy.LevelChoice == "Easy" && DontDestroy.NumberCorrect == 9 && DontDestroy.timeLeft < 40.0 && DontDestroy.timeLeft >= 20.0)
            {
                TimeBonus = 45.0f;
                ScoreText.text = "Your Score: " + DontDestroy.Score;
                StartCoroutine(GetScoreWithBonus());
            }

            if (DontDestroy.LevelChoice == "Easy" && DontDestroy.NumberCorrect == 9 && DontDestroy.timeLeft < 20.0)
            {
                TimeBonus = 35.0f;
                ScoreText.text = "Your Score: " + DontDestroy.Score;
                StartCoroutine(GetScoreWithBonus());
            }


            if (DontDestroy.NumberCorrect == 9)   //If all 9 are correct, show congrats text.
            {
                CongratsText.gameObject.SetActive(true);
                CongratsAudio.Play();
            }


            if (DontDestroy.NumberCorrect < 9)  //If any are incorrect, show fail text.
            {
                FailText.gameObject.SetActive(true);
                ScoreText.text = "Your Score: " + DontDestroy.Score;
                FailAudio.Play();
            }
        }

        if (DontDestroy.GameChoice == "Hazards")
        {
            print(DontDestroy.timeLeft);

            if (DontDestroy.LevelChoice == "Hard" && DontDestroy.NumberCorrect == 12)
            {
                TimeBonus = 55.0f;

                ScoreText.text = "Your Score: " + DontDestroy.Score;
                StartCoroutine(GetScoreWithBonus());

            }

            if (DontDestroy.LevelChoice == "Medium" && DontDestroy.NumberCorrect == 12 && DontDestroy.timeLeft >= 10.0)
            {
                TimeBonus = 55.0f;
                ScoreText.text = "Your Score: " + DontDestroy.Score;
                StartCoroutine(GetScoreWithBonus());
            }

            if (DontDestroy.LevelChoice == "Medium" && DontDestroy.NumberCorrect == 12 && DontDestroy.timeLeft < 10.0)
            {
                TimeBonus = 45.0f;
                ScoreText.text = "Your Score: " + DontDestroy.Score;
                StartCoroutine(GetScoreWithBonus());
            }

            if (DontDestroy.LevelChoice == "Easy" && DontDestroy.NumberCorrect == 12 && DontDestroy.timeLeft >= 15.0)
            {
                TimeBonus = 55.0f;
                ScoreText.text = "Your Score: " + DontDestroy.Score;
                StartCoroutine(GetScoreWithBonus());
            }

            if (DontDestroy.LevelChoice == "Easy" && DontDestroy.NumberCorrect == 12 && DontDestroy.timeLeft < 15.0 && DontDestroy.timeLeft >= 10.0)
            {
                TimeBonus = 45.0f;
                ScoreText.text = "Your Score: " + DontDestroy.Score;
                StartCoroutine(GetScoreWithBonus());
            }

            if (DontDestroy.LevelChoice == "Easy" && DontDestroy.NumberCorrect == 12 && DontDestroy.timeLeft < 10.0)
            {
                TimeBonus = 35.0f;
                ScoreText.text = "Your Score: " + DontDestroy.Score;
                StartCoroutine(GetScoreWithBonus());
            }


            if (DontDestroy.NumberCorrect ==  12)   //If all 9 are correct, show congrats text.
            {
                CongratsText.gameObject.SetActive(true);
                CongratsAudio.Play();
            }


            if (DontDestroy.NumberCorrect < 12)  //If any are incorrect, show fail text.
            {
                FailText.gameObject.SetActive(true);
                ScoreText.text = "Your Score: " + DontDestroy.Score;
                FailAudio.Play();
            }
        }




        if (DontDestroy.GameChoice == "Valves")
        {
            print("Time left: " + DontDestroy.timeLeft);

            if (DontDestroy.LevelChoice == "Hard" && DontDestroy.NumberCorrect == 1 && DontDestroy.CaughtGuessing == false)
            {
                TimeBonus = 55.0f;

                ScoreText.text = "Your Score: " + DontDestroy.Score;
                StartCoroutine(GetScoreWithBonus());

            }

            if (DontDestroy.LevelChoice == "Medium" && DontDestroy.NumberCorrect == 1 && DontDestroy.timeLeft >= 20.0 && DontDestroy.CaughtGuessing == false)
            {
                TimeBonus = 55.0f;
                ScoreText.text = "Your Score: " + DontDestroy.Score;
                StartCoroutine(GetScoreWithBonus());
            }

            if (DontDestroy.LevelChoice == "Medium" && DontDestroy.NumberCorrect == 1 && DontDestroy.timeLeft < 20.0 && DontDestroy.CaughtGuessing == false)
            {
                TimeBonus = 45.0f;
                ScoreText.text = "Your Score: " + DontDestroy.Score;
                StartCoroutine(GetScoreWithBonus());
            }

            if (DontDestroy.LevelChoice == "Easy" && DontDestroy.NumberCorrect == 1 && DontDestroy.timeLeft >= 40.0 && DontDestroy.CaughtGuessing == false)
            {
                TimeBonus = 55.0f;
                ScoreText.text = "Your Score: " + DontDestroy.Score;
                StartCoroutine(GetScoreWithBonus());
            }

            if (DontDestroy.LevelChoice == "Easy" && DontDestroy.NumberCorrect == 1 && DontDestroy.timeLeft < 40.0 && DontDestroy.timeLeft >= 20.0 && DontDestroy.CaughtGuessing == false)
            {
                TimeBonus = 45.0f;
                ScoreText.text = "Your Score: " + DontDestroy.Score;
                StartCoroutine(GetScoreWithBonus());
            }

            if (DontDestroy.LevelChoice == "Easy" && DontDestroy.NumberCorrect == 1 && DontDestroy.timeLeft < 20.0 && DontDestroy.CaughtGuessing == false)
            {
                TimeBonus = 35.0f;
                ScoreText.text = "Your Score: " + DontDestroy.Score;
                StartCoroutine(GetScoreWithBonus());
            }


            if (DontDestroy.NumberCorrect == 1 && DontDestroy.CaughtGuessing == false)   //If all are correct, show congrats text.
            {
                CongratsText.gameObject.SetActive(true);
                CongratsAudio.Play();
            }

            if(DontDestroy.NumberTimesChecked == 3 && DontDestroy.CaughtGuessing == true)
            {
                FailTooManyTriesText.gameObject.SetActive(true);
                ScoreText.text = "Your Score: " + DontDestroy.Score;
                FailAudio.Play();
            }

            if (DontDestroy.NumberCorrect == 0 && DontDestroy.timeLeft <= 0.0 && DontDestroy.CaughtGuessing == false)  //If any are incorrect, show fail text.
            {
                FailOutOfTimeText.gameObject.SetActive(true);
                ScoreText.text = "Your Score: " + DontDestroy.Score;
                FailAudio.Play();
            }

            if (DontDestroy.NumberCorrect == 0 && DontDestroy.timeLeft > 0.0 && DontDestroy.CaughtGuessing == false)  //If any are incorrect, show fail text.
            {
                FailDirectionsText.gameObject.SetActive(true);
                ScoreText.text = "Your Score: " + DontDestroy.Score;
                FailAudio.Play();
            }
        }
    }

    public IEnumerator GetScoreWithBonus()
    {
        print("start delay");
        yield return new WaitForSeconds(1);
        TimeBonusText.GetComponent<Text>().text = "+" + TimeBonus.ToString();
        TotalScoreWithTimeBonus = DontDestroy.Score + TimeBonus;
        TimeBonusGameObject.gameObject.SetActive(true);
        TimeBonusAudio.Play();
        yield return new WaitForSeconds(2);
        TimeBonusGameObject.gameObject.SetActive(false);
        ScoreText.GetComponent<Text>().text = "Your Score: " + TotalScoreWithTimeBonus;
        print("end delay");
    }
}
