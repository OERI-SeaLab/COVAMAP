using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteWireButton16 : MonoBehaviour
{
    public GameObject TheDeleteWireButton16;
    public GameObject Wire16;
    // Start is called before the first frame update
    void OnMouseDown()
    {
        TheDeleteWireButton16.SetActive(false);
        Wire16.SetActive(false);
    }

}
