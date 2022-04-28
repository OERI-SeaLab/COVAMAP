using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Activate/Deactivate the direction buttons to flip the valves
public class DirectionButton : MonoBehaviour
{
    //All inactive to start
    void Start()
    {
        for (int i = 0; i < DirectionButtons.Count; i++)
        {
            DirectionButtons[i].SetActive(false);
        }
    }
    public List<GameObject> Valves;
    public List<GameObject> DirectionButtons;

    // Directional buttons only show up when valves has been dropped into place
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
