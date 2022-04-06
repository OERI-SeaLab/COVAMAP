using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteWireButton7 : MonoBehaviour
{
    public GameObject TheDeleteWireButton7;
    public GameObject Wire7;
    // Start is called before the first frame update
    void OnMouseDown()
    {
        TheDeleteWireButton7.SetActive(false);
        Wire7.SetActive(false);
    }

}
