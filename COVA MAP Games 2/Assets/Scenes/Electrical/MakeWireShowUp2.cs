using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeWireShowUp2 : MonoBehaviour
{
    public GameObject wire2;
    public GameObject RemoveWireButton2;

    // Start is called before the first frame update
    private void OnMouseDown()
    {
        wire2.SetActive(true);
        RemoveWireButton2.SetActive(true);

        if (DontDestroy.WireColor == "red")
        {
            wire2.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        if (DontDestroy.WireColor == "blue")
        {
            wire2.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        if (DontDestroy.WireColor == "white")
        {
            wire2.GetComponent<MeshRenderer>().material.color = Color.white;
        }
        if (DontDestroy.WireColor == "black")
        {
            wire2.GetComponent<MeshRenderer>().material.color = Color.black;
        }
        if (DontDestroy.CableType == "F4")
        {
            wire2.GetComponent<WireType>().TheWireType = 4;
        }
        if (DontDestroy.CableType == "F2")
        {
            wire2.GetComponent<WireType>().TheWireType = 2;
        }
    }
}
