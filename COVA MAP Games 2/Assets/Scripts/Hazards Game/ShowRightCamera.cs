using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowRightCamera : MonoBehaviour
{

    public Camera cam1;
    public Camera cam2;
    public Camera cam3;
    public Camera cam4;
    public Camera cam5;
    public Camera cam6;
    public Camera cam7;
    public Camera cam8;
    public Camera cam9;
    public Camera cam10;
    public Camera cam11;



    public void Start()
    {
        cam1.gameObject.SetActive(false);
        cam1.GetComponent<AudioListener>().enabled = false;
        cam2.gameObject.SetActive(false);
        cam2.GetComponent<AudioListener>().enabled = false;
        cam3.gameObject.SetActive(false);
        cam3.GetComponent<AudioListener>().enabled = false;
        cam4.gameObject.SetActive(false);
        cam4.GetComponent<AudioListener>().enabled = false;
        cam5.gameObject.SetActive(false);
        cam5.GetComponent<AudioListener>().enabled = false;
        cam6.gameObject.SetActive(false);
        cam6.GetComponent<AudioListener>().enabled = false;
        cam7.gameObject.SetActive(false);
        cam7.GetComponent<AudioListener>().enabled = false;
        cam8.gameObject.SetActive(false);
        cam8.GetComponent<AudioListener>().enabled = false;
        cam9.gameObject.SetActive(false);
        cam9.GetComponent<AudioListener>().enabled = false;
        cam10.gameObject.SetActive(false);
        cam10.GetComponent<AudioListener>().enabled = false;
        cam11.gameObject.SetActive(false);
        cam11.GetComponent<AudioListener>().enabled = false;


        if (DontDestroy.ScenarioChoice.Contains("1"))
        {
            cam1.gameObject.SetActive(true);
            cam1.GetComponent<AudioListener>().enabled = true;
            print("cAmera enabled IS : cam1");
        }

        if (DontDestroy.ScenarioChoice.Contains("2"))
        {
            cam2.gameObject.SetActive(true);
            cam2.GetComponent<AudioListener>().enabled = true;
            print("cAmera enabled IS : cam2");
        }
        if (DontDestroy.ScenarioChoice.Contains("3"))
        {
            cam3.gameObject.SetActive(true);
            cam3.GetComponent<AudioListener>().enabled = true;
            print("cAmera enabled IS : cam3");
        }
        if (DontDestroy.ScenarioChoice.Contains("4"))
        {
            cam4.gameObject.SetActive(true);
            cam4.GetComponent<AudioListener>().enabled = true;
        }
        if (DontDestroy.ScenarioChoice.Contains("5"))
        {
            cam5.gameObject.SetActive(true);
            cam5.GetComponent<AudioListener>().enabled = true;
        }
        if (DontDestroy.ScenarioChoice.Contains("6"))
        {
            cam6.gameObject.SetActive(true);
            cam6.GetComponent<AudioListener>().enabled = true;
        }
        if (DontDestroy.ScenarioChoice.Contains("7"))
        {
            cam7.gameObject.SetActive(true);
            cam7.GetComponent<AudioListener>().enabled = true;
        }
        if (DontDestroy.ScenarioChoice.Contains("8"))
        {
            cam8.gameObject.SetActive(true);
            cam8.GetComponent<AudioListener>().enabled = true;
        }
        if (DontDestroy.ScenarioChoice.Contains("9"))
        {
            cam9.gameObject.SetActive(true);
            cam9.GetComponent<AudioListener>().enabled = true;
        }
        if (DontDestroy.ScenarioChoice.Contains("10"))
        {
            cam10.gameObject.SetActive(true);
            cam10.GetComponent<AudioListener>().enabled = true;
        }
        if (DontDestroy.ScenarioChoice.Contains("11"))
        {
            cam11.gameObject.SetActive(true);
            cam11.GetComponent<AudioListener>().enabled = true;
        }



    }


    
}
