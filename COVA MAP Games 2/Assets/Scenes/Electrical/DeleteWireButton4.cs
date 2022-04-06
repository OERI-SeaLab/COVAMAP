using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteWireButton4 : MonoBehaviour
{
    public GameObject TheDeleteWireButton4;
    public GameObject Wire4;
    // Start is called before the first frame update
    void OnMouseDown()
    {
        TheDeleteWireButton4.SetActive(false);
        Wire4.SetActive(false);
    }

}