using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeWireShowUp14 : MonoBehaviour
{
    public GameObject wire14;
    public GameObject RemoveWireButton14;

    // Start is called before the first frame update
    private void OnMouseDown()
    {
        wire14.SetActive(true);
        RemoveWireButton14.SetActive(true);

        if (DontDestroy.WireColor == "red")
        {
            wire14.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        if (DontDestroy.WireColor == "blue")
        {
            wire14.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        if (DontDestroy.WireColor == "white")
        {
            wire14.GetComponent<MeshRenderer>().material.color = Color.white;
        }
        if (DontDestroy.WireColor == "black")
        {
            wire14.GetComponent<MeshRenderer>().material.color = Color.black;
        }
        if (DontDestroy.CableType == "F4")
        {
            wire14.GetComponent<WireType>().TheWireType = 4;
        }
        if (DontDestroy.CableType == "F2")
        {
            wire14.GetComponent<WireType>().TheWireType = 2;
        }
    }
}