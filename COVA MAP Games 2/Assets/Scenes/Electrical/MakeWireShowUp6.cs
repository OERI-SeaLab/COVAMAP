using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeWireShowUp6 : MonoBehaviour
{
    public GameObject wire6;
    public GameObject RemoveWireButton6;

    // Start is called before the first frame update
    private void OnMouseDown()
    {
        wire6.SetActive(true);
        RemoveWireButton6.SetActive(true);

        if (DontDestroy.WireColor == "red")
        {
            wire6.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        if (DontDestroy.WireColor == "blue")
        {
            wire6.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        if (DontDestroy.WireColor == "white")
        {
            wire6.GetComponent<MeshRenderer>().material.color = Color.white;
        }
        if (DontDestroy.WireColor == "black")
        {
            wire6.GetComponent<MeshRenderer>().material.color = Color.black;
        }
        if (DontDestroy.CableType == "F4")
        {
            wire6.GetComponent<WireType>().TheWireType = 4;
        }
        if (DontDestroy.CableType == "F2")
        {
            wire6.GetComponent<WireType>().TheWireType = 2;
        }
    }
}
