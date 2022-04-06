using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeWireShowUp13 : MonoBehaviour
{
    public GameObject wire13;
    public GameObject RemoveWireButton13;

    // Start is called before the first frame update
    private void OnMouseDown()
    {
        wire13.SetActive(true);
        RemoveWireButton13.SetActive(true);

        if (DontDestroy.WireColor == "red")
        {
            wire13.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        if (DontDestroy.WireColor == "blue")
        {
            wire13.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        if (DontDestroy.WireColor == "white")
        {
            wire13.GetComponent<MeshRenderer>().material.color = Color.white;
        }
        if (DontDestroy.WireColor == "black")
        {
            wire13.GetComponent<MeshRenderer>().material.color = Color.black;
        }
        if (DontDestroy.CableType == "F4")
        {
            wire13.GetComponent<WireType>().TheWireType = 4;
        }
        if (DontDestroy.CableType == "F2")
        {
            wire13.GetComponent<WireType>().TheWireType = 2;
        }
    }
}