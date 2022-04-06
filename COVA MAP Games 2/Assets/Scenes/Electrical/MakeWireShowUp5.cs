using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeWireShowUp5 : MonoBehaviour
{
    public GameObject wire5;
    public GameObject RemoveWireButton5;

    // Start is called before the first frame update
    private void OnMouseDown()
    {
        wire5.SetActive(true);
        RemoveWireButton5.SetActive(true);

        if (DontDestroy.WireColor == "red")
        {
            wire5.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        if (DontDestroy.WireColor == "blue")
        {
            wire5.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        if (DontDestroy.WireColor == "white")
        {
            wire5.GetComponent<MeshRenderer>().material.color = Color.white;
        }
        if (DontDestroy.WireColor == "black")
        {
            wire5.GetComponent<MeshRenderer>().material.color = Color.black;
        }
        if (DontDestroy.CableType == "F4")
        {
            wire5.GetComponent<WireType>().TheWireType = 4;
        }
        if (DontDestroy.CableType == "F2")
        {
            wire5.GetComponent<WireType>().TheWireType = 2;
        }
    }
}