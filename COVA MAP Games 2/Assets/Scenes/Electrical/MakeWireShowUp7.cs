using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeWireShowUp7 : MonoBehaviour
{
    public GameObject wire7;
    public GameObject RemoveWireButton7;

    // Start is called before the first frame update
    private void OnMouseDown()
    {
        wire7.SetActive(true);
        RemoveWireButton7.SetActive(true);

        if (DontDestroy.WireColor == "red")
        {
            wire7.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        if (DontDestroy.WireColor == "blue")
        {
            wire7.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        if (DontDestroy.WireColor == "white")
        {
            wire7.GetComponent<MeshRenderer>().material.color = Color.white;
        }
        if (DontDestroy.WireColor == "black")
        {
            wire7.GetComponent<MeshRenderer>().material.color = Color.black;
        }
        if (DontDestroy.CableType == "F4")
        {
            wire7.GetComponent<WireType>().TheWireType = 4;
        }
        if (DontDestroy.CableType == "F2")
        {
            wire7.GetComponent<WireType>().TheWireType = 2;
        }
    }
}