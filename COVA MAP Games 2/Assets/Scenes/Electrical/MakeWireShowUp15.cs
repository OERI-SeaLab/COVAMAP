using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeWireShowUp15 : MonoBehaviour
{
    public GameObject wire15;
    public GameObject RemoveWireButton15;

    // Start is called before the first frame update
    private void OnMouseDown()
    {
        wire15.SetActive(true);
        RemoveWireButton15.SetActive(true);

        if (DontDestroy.WireColor == "red")
        {
            wire15.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        if (DontDestroy.WireColor == "blue")
        {
            wire15.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        if (DontDestroy.WireColor == "white")
        {
            wire15.GetComponent<MeshRenderer>().material.color = Color.white;
        }
        if (DontDestroy.WireColor == "black")
        {
            wire15.GetComponent<MeshRenderer>().material.color = Color.black;
        }
    }
}