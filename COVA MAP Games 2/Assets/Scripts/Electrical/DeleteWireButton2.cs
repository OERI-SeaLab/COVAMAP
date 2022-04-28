using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteWireButton2 : MonoBehaviour
{
    //public GameObject TheDeleteWireButton;
    public GameObject Wire;
    // Start is called before the first frame update
    void OnMouseDown()
    {
        this.gameObject.SetActive(false);
        Wire.SetActive(false);
    }

}
