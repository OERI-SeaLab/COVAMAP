using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeWireShowUp : MonoBehaviour
{
    public GameObject wire1;
    public GameObject RemoveWireButton1;

    // Start is called before the first frame update
    private void OnMouseDown()
    {
        wire1.SetActive(true);
        RemoveWireButton1.SetActive(true);

        if (DontDestroy.WireColor == "red")
        {
            wire1.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        if (DontDestroy.WireColor == "blue")
        {
            wire1.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        if (DontDestroy.WireColor == "white")
        {
            wire1.GetComponent<MeshRenderer>().material.color = Color.white;
        }
        if (DontDestroy.WireColor == "black")
        {
            wire1.GetComponent<MeshRenderer>().material.color = Color.black;
        }
    }
}
