using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeWireShowUp3 : MonoBehaviour
{
    public GameObject wire3;
    public GameObject RemoveWireButton3;

    // Start is called before the first frame update
    private void OnMouseDown()
    {
        wire3.SetActive(true);
        RemoveWireButton3.SetActive(true);

        if (DontDestroy.WireColor == "red")
        {
            wire3.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        if (DontDestroy.WireColor == "blue")
        {
            wire3.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        if (DontDestroy.WireColor == "white")
        {
            wire3.GetComponent<MeshRenderer>().material.color = Color.white;
        }
        if (DontDestroy.WireColor == "black")
        {
            wire3.GetComponent<MeshRenderer>().material.color = Color.black;
        }
    }
}