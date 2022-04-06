using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteWireButton14 : MonoBehaviour
{
    public GameObject TheDeleteWireButton14;
    public GameObject Wire14;
    // Start is called before the first frame update
    void OnMouseDown()
    {
        TheDeleteWireButton14.SetActive(false);
        Wire14.SetActive(false);
    }

}