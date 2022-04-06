using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteWireButton2 : MonoBehaviour
{
    public GameObject TheDeleteWireButton2;
    public GameObject Wire2;
    // Start is called before the first frame update
    void OnMouseDown()
    {
        TheDeleteWireButton2.SetActive(false);
        Wire2.SetActive(false);
    }

}
