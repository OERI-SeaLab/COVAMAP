using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// On play, start at the Intro scene.

public class AutoStartMainMenu : MonoBehaviour
{
#if UNITY_EDITOR
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    static void Init()
    {
        SceneManager.LoadScene("Intro");
    }
#endif
}
