using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteWireButton13 : MonoBehaviour
{
    public GameObject TheDeleteWireButton13;
    public GameObject Wire13;
    // Start is called before the first frame update
    void OnMouseDown()
    {
        TheDeleteWireButton13.SetActive(false);
        Wire13.SetActive(false);
    }

}
