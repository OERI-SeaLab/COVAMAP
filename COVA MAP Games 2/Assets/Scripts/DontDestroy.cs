using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//List of variables to not destroy throughout game.

public class DontDestroy : MonoBehaviour
{
    public static string LevelChoice;

    public static string GameChoice;

    public static List<string> CorrectList = new List<string>();

    public static List<string> CorrectHazardsList = new List<string>();

    public static string ScenarioChoice;
    public static List<string> ScenarioList = new List<string>();
    
    public static string InstructionsText;
    public static List<string> InstructionsList = new List<string>();

    public static string NumberOfValves;

    public static string ScenarioReminderText;

    public static string AboutGameText;

    public static int Score = 0;
    public static int NumberCorrect;
    public static int NumberTimesChecked; //used for valve game
    public static int[] NumberTimesCheckedPerValveArray = new int[5];
    public static int NumberTimesCheckedPerValve=0;
    public static bool CaughtGuessing = false;

    public static bool ElectricalWon = false;


    public static bool BeenThroughFirstValveScenario;

    public static int ScenarioCounter = 0;

    public static float timeLeft = 0.0f;

    public static string WireColor;
    public static string CableType;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
