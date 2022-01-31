using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopPlayingMusic : MonoBehaviour
{
    // Start is called before the first frame update

    public void StopBackGroundMusic()
    {
        GameObject.FindGameObjectWithTag("Music").GetComponent<PlayAudio>().StopMusic();
    }
}
