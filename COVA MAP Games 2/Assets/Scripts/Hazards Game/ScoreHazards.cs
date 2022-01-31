using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreHazards : MonoBehaviour
{
    public void GetScore()
    {
        print("GETTING HERE!!!!!!!!!");
        if (DontDestroy.LevelChoice == "Easy")
        {
            DontDestroy.Score = DontDestroy.NumberCorrect * 45 / 12;
            Debug.Log(DontDestroy.Score);

        }
        else if (DontDestroy.LevelChoice == "Medium")
        {
            DontDestroy.Score = DontDestroy.NumberCorrect * 45 / 12;
            Debug.Log(DontDestroy.Score);

        }
        else if (DontDestroy.LevelChoice == "Hard")
        {
            DontDestroy.Score = DontDestroy.NumberCorrect * 45 / 12;
            Debug.Log(DontDestroy.Score);

        }

        SceneManager.LoadScene("ScoreboardHazards");
    }
}