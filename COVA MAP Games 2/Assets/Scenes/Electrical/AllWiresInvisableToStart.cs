using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllWiresInvisableToStart : MonoBehaviour
{
    public GameObject[] AllWires;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject go in AllWires)
            go.SetActive(false);
    }

    
}
