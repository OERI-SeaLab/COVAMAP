using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckButton : MonoBehaviour
{
    public GameObject NextButtonPanel;


    // Start is called before the first frame update
    public void CheckDirections()
    {
        //SceneManager.LoadScene("ScoreboardValves");
        if (CheckFlipDirections())
        {
            print("You are the winner");
            DontDestroy.NumberCorrect = 1;
        }
        else
        {
            print("You are the loser");
            DontDestroy.NumberCorrect = 0;
        }
        SceneManager.LoadScene("ScoreboardValves");
    }

    public bool CheckFlipDirections()
    {
        FlipDirection[] flipDirections = FindObjectsOfType<FlipDirection>();
        if (flipDirections.Length == 0) return true;

        for (int i = 0; i < flipDirections.Length; i++)
        {
            if (flipDirections[i].flipindex != flipDirections[i].correctFlipIndex)
            {
                return false;
            }
        }

        return true;
    }
}
