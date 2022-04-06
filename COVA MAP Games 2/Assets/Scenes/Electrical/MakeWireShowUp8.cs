using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeWireShowUp8 : MonoBehaviour
{
    public GameObject wire8;
    public GameObject RemoveWireButton8;

    // Start is called before the first frame update
    private void OnMouseDown()
    {
        wire8.SetActive(true);
        RemoveWireButton8.SetActive(true);

        if (DontDestroy.WireColor == "red")
        {
            wire8.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        if (DontDestroy.WireColor == "blue")
        {
            wire8.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        if (DontDestroy.WireColor == "white")
        {
            wire8.GetComponent<MeshRenderer>().material.color = Color.white;
        }
        if (DontDestroy.WireColor == "black")
        {
            wire8.GetComponent<MeshRenderer>().material.color = Color.black;
        }
        if (DontDestroy.CableType == "F4")
        {
            wire8.GetComponent<WireType>().TheWireType = 4;
        }
        if (DontDestroy.CableType == "F2")
        {
            wire8.GetComponent<WireType>().TheWireType = 2;
        }
    }
}