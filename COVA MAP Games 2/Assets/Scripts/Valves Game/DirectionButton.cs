using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionButton : MonoBehaviour
{
    void Start()
    {
        for (int i = 0; i < DirectionButtons.Count; i++)
        {
            DirectionButtons[i].SetActive(false);
        }
    }
    public List<GameObject> Valves;
    public List<GameObject> DirectionButtons;

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Valves.Count; i++)
        {
            if (Valves[i].activeInHierarchy)
            {
                DirectionButtons[i].SetActive(true);
            }
        }
    }
}
