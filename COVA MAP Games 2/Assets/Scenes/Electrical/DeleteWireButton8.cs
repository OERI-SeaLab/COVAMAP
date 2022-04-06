using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteWireButton8 : MonoBehaviour
{
    public GameObject TheDeleteWireButton8;
    public GameObject Wire8;
    // Start is called before the first frame update
    void OnMouseDown()
    {
        TheDeleteWireButton8.SetActive(false);
        Wire8.SetActive(false);
    }

}
