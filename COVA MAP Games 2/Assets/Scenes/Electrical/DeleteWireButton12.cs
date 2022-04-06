using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteWireButton12 : MonoBehaviour
{
    public GameObject TheDeleteWireButton12;
    public GameObject Wire12;
    // Start is called before the first frame update
    void OnMouseDown()
    {
        TheDeleteWireButton12.SetActive(false);
        Wire12.SetActive(false);
    }

}
