using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeWireShowUp10 : MonoBehaviour
{
    public GameObject wire10;
    public GameObject RemoveWireButton10;

    // Start is called before the first frame update
    private void OnMouseDown()
    {
        wire10.SetActive(true);
        RemoveWireButton10.SetActive(true);

        if (DontDestroy.WireColor == "red")
        {
            wire10.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        if (DontDestroy.WireColor == "blue")
        {
            wire10.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        if (DontDestroy.WireColor == "white")
        {
            wire10.GetComponent<MeshRenderer>().material.color = Color.white;
        }
        if (DontDestroy.WireColor == "black")
        {
            wire10.GetComponent<MeshRenderer>().material.color = Color.black;
        }
    }
}
