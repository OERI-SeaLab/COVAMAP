using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteWireButton6 : MonoBehaviour
{
    public GameObject TheDeleteWireButton6;
    public GameObject Wire6;
    // Start is called before the first frame update
    void OnMouseDown()
    {
        TheDeleteWireButton6.SetActive(false);
        Wire6.SetActive(false);
    }

}
