using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class ButtonControls : MonoBehaviour
{

// -------- Intro Scene ----------- //

    //Skip the into and go straight to the main menu.
    public void SkipIntroButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

// -------- MainMenu Scene ----------- //

    //Press play games to choose a level.
    public void PlayGamesButton()
    {
        SceneManager.LoadScene("Levels");
    }

    //Press quit to go to quit screen and then close the application.
    public void QuitButton()
    {
        SceneManager.LoadScene("Quit");
    }

    // -------- Levels Scene ----------- //

    public string LevelChoice;

    //Save the level choice in DoNotDestroy so it can be used in future scenes.

    public void EasyChoiceButton()
    {   
        LevelChoice = "Easy";
        DontDestroy.LevelChoice = LevelChoice;
        SceneManager.LoadScene("Games");
        Debug.Log(DontDestroy.LevelChoice);
    }

    public void MediumChoiceButton()
    {   
        LevelChoice = "Medium";
        DontDestroy.LevelChoice = LevelChoice;
        SceneManager.LoadScene("Games");
        Debug.Log(DontDestroy.LevelChoice);
    }

    public void HardChoiceButton()
    {   
        LevelChoice = "Hard";
        DontDestroy.LevelChoice = LevelChoice;
        SceneManager.LoadScene("Games");
        Debug.Log(DontDestroy.LevelChoice);
    }

    //Press the back button to go back to the main menu scene.
    public void LevelsBackButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

// -------- Games Scene ----------- //

    public string GameChoice;

    //Save the game choice in DoNotDestroy so it can be used in future scenes.

    public void PPEGameChoiceButton()
    {   
        GameChoice = "PPE";
        DontDestroy.GameChoice = GameChoice;
        SceneManager.LoadScene("About");
        Debug.Log(DontDestroy.GameChoice);
    }

    public void HazardsGameChoiceButton()
    {   
        GameChoice = "Hazards";
        DontDestroy.GameChoice = GameChoice;
        SceneManager.LoadScene("AboutHazards");
        Debug.Log(DontDestroy.GameChoice);
    }

    public void ValvesGameChoiceButton()
    {   
        GameChoice = "Valves";
        DontDestroy.GameChoice = GameChoice;
        SceneManager.LoadScene("AboutValves");
        Debug.Log(DontDestroy.GameChoice);
    }

    //Press the back button to go back to the choose level scene.

    public void GamesBackButton()
    {
        SceneManager.LoadScene("Levels");
    }

// -------- About Scene ----------- //

//Displays the instructions for the chosen game.

    //Press the back button to go back to the choose game scene.
    public void AboutBackButton()
    {
        SceneManager.LoadScene("Games");
    }

    //Press the next button to start the game.
    public void AboutNextButton()
    {
        SceneManager.LoadScene("PPE");
        Debug.Log("PPE Loaded");
    }

    public void AboutNextButtonValves() ///also used on scoreboard 
    {
        SceneManager.LoadScene("Valves");
        Debug.Log("Game Loaded");
    }

    public void AboutNextButtonHazards() ///also used on scoreboard 
    {
        SceneManager.LoadScene("Hazards");
        Debug.Log("Game Loaded");
    }


    // -------- Scoreboard Scene ----------- //

    //Press the Quit button on the Scoreboard to return to the main menu.
    public void ScoreboardQuitButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
