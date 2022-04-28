using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 
 public class PlayAudio : MonoBehaviour
{
    //Music system
    
    public AudioSource _audioSource;
    private GameObject[] other;
    private bool NotFirst = false;
    private void Awake()
    {
        other = GameObject.FindGameObjectsWithTag("Music");  //Caleb obviously did this

        foreach (GameObject oneOther in other)
        {
            if (oneOther.scene.buildIndex == -1)
            {
                NotFirst = true;
            }
        }

        if (NotFirst == true)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(transform.gameObject);
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlayMusic()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.Play();
    }

    public void StopMusic()
    {
        _audioSource.Stop();
    }
}