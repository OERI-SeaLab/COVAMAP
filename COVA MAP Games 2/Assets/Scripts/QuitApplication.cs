using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitApplication : MonoBehaviour
{
    //Delay the closing of the application by 4 seconds to allow for logos to be displayed. 
    
    public void Start()
    {
        Time.timeScale = 1;
        StartCoroutine(QuitTheApplication(4));
    }

    public IEnumerator QuitTheApplication(int sec)
    {
        Debug.Log("before the wait");
        yield return new WaitForSeconds(sec);
        Debug.Log("after the wait");
        Debug.Log("Quitting");
        #if (UNITY_EDITOR || DEVELOPMENT_BUILD)
        Debug.Log(this.name+" : "+this.GetType()+" : "+System.Reflection.MethodBase.GetCurrentMethod().Name); 
        #endif
        #if (UNITY_EDITOR)
        UnityEditor.EditorApplication.isPlaying = false;
        #elif (UNITY_STANDALONE) 
        Application.Quit();
        #elif (UNITY_WEBGL)
        Application.OpenURL("quit.html");
        #endif
    }

}
