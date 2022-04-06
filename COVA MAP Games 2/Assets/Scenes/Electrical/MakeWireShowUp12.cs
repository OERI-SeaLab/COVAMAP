using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeWireShowUp12 : MonoBehaviour
{
    public GameObject wire12;
    public GameObject RemoveWireButton12;

    // Start is called before the first frame update
    private void OnMouseDown()
    {
        wire12.SetActive(true);
        RemoveWireButton12.SetActive(true);

        if (DontDestroy.WireColor == "red")
        {
            wire12.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        if (DontDestroy.WireColor == "blue")
        {
            wire12.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        if (DontDestroy.WireColor == "white")
        {
            wire12.GetComponent<MeshRenderer>().material.color = Color.white;
        }
        if (DontDestroy.WireColor == "black")
        {
            wire12.GetComponent<MeshRenderer>().material.color = Color.black;
        }
        if (DontDestroy.CableType == "F4")
        {
            wire12.GetComponent<WireType>().TheWireType = 4;
        }
        if (DontDestroy.CableType == "F2")
        {
            wire12.GetComponent<WireType>().TheWireType = 2;
        }
    }
}
