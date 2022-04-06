using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteWireButton10 : MonoBehaviour
{
    public GameObject TheDeleteWireButton10;
    public GameObject Wire10;
    // Start is called before the first frame update
    void OnMouseDown()
    {
        TheDeleteWireButton10.SetActive(false);
        Wire10.SetActive(false);
    }

}