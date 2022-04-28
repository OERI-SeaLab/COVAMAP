using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F2PickBlackWire : MonoBehaviour
{
    public GameObject Bundle2B;
    public GameObject Bundle3B;
    public GameObject Bundle4B;
    public AllWiresInvisableToStart AllWiresInvisableToStartScript;
    private void OnMouseDown()
    {
        DontDestroy.CableType = "F2";
        DontDestroy.WireColor = "black";
        Bundle2B.SetActive(false);
        Bundle3B.SetActive(false);
        Bundle4B.SetActive(false);
        print(DontDestroy.WireColor);
        AllWiresInvisableToStartScript.EnableConnectors();
    }

}