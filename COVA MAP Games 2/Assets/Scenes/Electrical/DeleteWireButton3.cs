using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteWireButton3 : MonoBehaviour
{
    public GameObject TheDeleteWireButton3;
    public GameObject Wire3;
    // Start is called before the first frame update
    void OnMouseDown()
    {
        TheDeleteWireButton3.SetActive(false);
        Wire3.SetActive(false);
    }

}
