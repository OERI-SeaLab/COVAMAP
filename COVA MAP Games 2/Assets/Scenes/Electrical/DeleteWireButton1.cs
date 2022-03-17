using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteWireButton1 : MonoBehaviour
{
    public GameObject TheDeleteWireButton1;
    public GameObject Wire1;
    // Start is called before the first frame update
    void OnMouseDown()
    {
        TheDeleteWireButton1.SetActive(false);
        Wire1.SetActive(false);
    }

}
