using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickRedWire : MonoBehaviour
{
    public GameObject Bundle2B;
    public GameObject Bundle3B;
    public GameObject Bundle4B;
    public AllWiresInvisableToStart AllWiresInvisableToStartScript;


    // Update is called once per frame

    private void OnMouseDown()
    {
        DontDestroy.CableType = "F4";
        DontDestroy.WireColor = "red";
        Bundle2B.SetActive(false);
        Bundle3B.SetActive(false);
        Bundle4B.SetActive(false);
        print(DontDestroy.WireColor);
        AllWiresInvisableToStartScript.EnableConnectors();

    }

}
