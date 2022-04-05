using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeWireShowUp16 : MonoBehaviour
{
    public GameObject wire16;
    public GameObject RemoveWireButton16;

    // Start is called before the first frame update
    private void OnMouseDown()
    {
        wire16.SetActive(true);
        RemoveWireButton16.SetActive(true);

        if (DontDestroy.WireColor == "red")
        {
            wire16.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        if (DontDestroy.WireColor == "blue")
        {
            wire16.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        if (DontDestroy.WireColor == "white")
        {
            wire16.GetComponent<MeshRenderer>().material.color = Color.white;
        }
        if (DontDestroy.WireColor == "black")
        {
            wire16.GetComponent<MeshRenderer>().material.color = Color.black;
        }
    }
}