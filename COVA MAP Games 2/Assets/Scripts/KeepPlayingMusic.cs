using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepPlayingMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectWithTag("Music").GetComponent<PlayAudio>().PlayMusic();
    }

}
