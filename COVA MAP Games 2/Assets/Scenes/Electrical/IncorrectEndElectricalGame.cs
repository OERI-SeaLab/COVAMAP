using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IncorrectEndElectricalGame : MonoBehaviour
{
    // Start is called before the first frame update
    public void EndGame()
    {
        print("THe game is over");
        DontDestroy.ElectricalWon = false;
        SceneManager.LoadScene("ScoreboardElectrical");
    }

}
