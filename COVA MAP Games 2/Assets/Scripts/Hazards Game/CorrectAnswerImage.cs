using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectAnswerImage : MonoBehaviour
{

    public SpriteRenderer cam1;
    public SpriteRenderer cam2;
    public SpriteRenderer cam3;
    public SpriteRenderer cam4;
    public SpriteRenderer cam5;
    public SpriteRenderer cam6;
    public SpriteRenderer cam7;
    public SpriteRenderer cam8;
    public SpriteRenderer cam9;
    public SpriteRenderer cam10;
    public SpriteRenderer cam11;



    public void Start()
    {
        cam1.enabled = false;
        cam2.enabled = false;
        cam3.enabled = false;
        cam4.enabled = false;
        cam5.enabled = false;
        cam6.enabled = false;
        cam7.enabled = false;
        cam8.enabled = false;
        cam9.enabled = false;
        cam10.enabled = false;
        cam11.enabled = false;


        if (DontDestroy.ScenarioChoice.Contains("1"))
        {
            cam1.enabled = true;
        }

        if (DontDestroy.ScenarioChoice.Contains("2"))
        {
            cam2.enabled = true;
        }
        if (DontDestroy.ScenarioChoice.Contains("3"))
        {
            cam3.enabled = true;
        }
        if (DontDestroy.ScenarioChoice.Contains("4"))
        {
            cam4.enabled = true;
        }
        if (DontDestroy.ScenarioChoice.Contains("5"))
        {
            cam5.enabled = true;
        }
        if (DontDestroy.ScenarioChoice.Contains("6"))
        {
            cam6.enabled = true;
        }
        if (DontDestroy.ScenarioChoice.Contains("7"))
        {
            cam7.enabled = true;
        }
        if (DontDestroy.ScenarioChoice.Contains("8"))
        {
            cam8.enabled = true;
        }
        if (DontDestroy.ScenarioChoice.Contains("9"))
        {
            cam9.enabled = true;
        }
        if (DontDestroy.ScenarioChoice.Contains("10"))
        {
            cam10.enabled = true;
        }
        if (DontDestroy.ScenarioChoice.Contains("11"))
        {
            cam11.enabled = true;
        }



    }



}
