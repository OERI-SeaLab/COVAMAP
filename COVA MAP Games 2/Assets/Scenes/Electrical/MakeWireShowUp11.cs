using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeWireShowUp11 : MonoBehaviour
{
    public GameObject wire11;
    public GameObject RemoveWireButton11;

    // Start is called before the first frame update
    private void OnMouseDown()
    {
        wire11.SetActive(true);
        RemoveWireButton11.SetActive(true);

        if (DontDestroy.WireColor == "red")
        {
            wire11.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        if (DontDestroy.WireColor == "blue")
        {
            wire11.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        if (DontDestroy.WireColor == "white")
        {
            wire11.GetComponent<MeshRenderer>().material.color = Color.white;
        }
        if (DontDestroy.WireColor == "black")
        {
            wire11.GetComponent<MeshRenderer>().material.color = Color.black;
        }
        if (DontDestroy.CableType == "F4")
        {
            wire11.GetComponent<WireType>().TheWireType = 4;
        }
        if (DontDestroy.CableType == "F2")
        {
            wire11.GetComponent<WireType>().TheWireType = 2;
        }
    }
}
