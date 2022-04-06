using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteWireButton15 : MonoBehaviour
{
    public GameObject TheDeleteWireButton15;
    public GameObject Wire15;
    // Start is called before the first frame update
    void OnMouseDown()
    {
        TheDeleteWireButton15.SetActive(false);
        Wire15.SetActive(false);
    }

}
