using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllWiresInvisableToStart : MonoBehaviour
{
    public GameObject[] AllWires;
    public GameObject[] AllConnectors;


    // Start is called before the first frame update
    void Start()
    {
        DontDestroy.CableType = "";
        DontDestroy.WireColor = "";
        foreach (GameObject go in AllWires)
            go.SetActive(false);
        foreach (GameObject go in AllConnectors)
            go.SetActive(false);
    }

    public void DisableConnectors()
    {
        foreach (GameObject go in AllConnectors)
            go.SetActive(false);
    }
    
    public void EnableConnectors()
    {
        foreach (GameObject go in AllConnectors)
            go.SetActive(true);
    }

    
}
