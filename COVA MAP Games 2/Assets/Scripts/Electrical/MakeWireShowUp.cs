using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeWireShowUp : MonoBehaviour
{
    public GameObject wire;
    public GameObject RemoveWireButton;

    // Start is called before the first frame update
    private void OnMouseDown()
    {
        wire.SetActive(true);
        RemoveWireButton.SetActive(true);

        if (DontDestroy.WireColor == "red")
        {
            wire.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        if (DontDestroy.WireColor == "blue")
        {
            wire.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        if (DontDestroy.WireColor == "white")
        {
            wire.GetComponent<MeshRenderer>().material.color = Color.white;
        }
        if (DontDestroy.WireColor == "black")
        {
            wire.GetComponent<MeshRenderer>().material.color = Color.black;
        }
        if(DontDestroy.CableType == "F4")
        {
            wire.GetComponent<WireType>().TheWireType = 4;
        }
        if (DontDestroy.CableType == "F2")
        {
            wire.GetComponent<WireType>().TheWireType = 2;
        }
    }
}
