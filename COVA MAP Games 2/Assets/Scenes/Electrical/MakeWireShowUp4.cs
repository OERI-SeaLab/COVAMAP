using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeWireShowUp4 : MonoBehaviour
{
    public GameObject wire4;
    public GameObject RemoveWireButton4;

    // Start is called before the first frame update
    private void OnMouseDown()
    {
        wire4.SetActive(true);
        RemoveWireButton4.SetActive(true);

        if (DontDestroy.WireColor == "red")
        {
            wire4.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        if (DontDestroy.WireColor == "blue")
        {
            wire4.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        if (DontDestroy.WireColor == "white")
        {
            wire4.GetComponent<MeshRenderer>().material.color = Color.white;
        }
        if (DontDestroy.WireColor == "black")
        {
            wire4.GetComponent<MeshRenderer>().material.color = Color.black;
        }
    }
}