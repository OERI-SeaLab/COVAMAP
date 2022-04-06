using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteWireButton5 : MonoBehaviour
{
    public GameObject TheDeleteWireButton5;
    public GameObject Wire5;
    // Start is called before the first frame update
    void OnMouseDown()
    {
        TheDeleteWireButton5.SetActive(false);
        Wire5.SetActive(false);
    }

}
