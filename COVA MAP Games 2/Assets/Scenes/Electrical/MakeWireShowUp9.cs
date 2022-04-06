using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeWireShowUp9 : MonoBehaviour
{
    public GameObject wire9;
    public GameObject RemoveWireButton9;

    // Start is called before the first frame update
    private void OnMouseDown()
    {
        wire9.SetActive(true);
        RemoveWireButton9.SetActive(true);

        if (DontDestroy.WireColor == "red")
        {
            wire9.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        if (DontDestroy.WireColor == "blue")
        {
            wire9.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        if (DontDestroy.WireColor == "white")
        {
            wire9.GetComponent<MeshRenderer>().material.color = Color.white;
        }
        if (DontDestroy.WireColor == "black")
        {
            wire9.GetComponent<MeshRenderer>().material.color = Color.black;
        }
        if (DontDestroy.CableType == "F4")
        {
            wire9.GetComponent<WireType>().TheWireType = 4;
        }
        if (DontDestroy.CableType == "F2")
        {
            wire9.GetComponent<WireType>().TheWireType = 2;
        }
    }
}
