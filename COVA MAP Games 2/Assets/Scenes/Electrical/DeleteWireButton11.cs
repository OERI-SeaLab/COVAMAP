using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteWireButton11 : MonoBehaviour
{
    public GameObject TheDeleteWireButton11;
    public GameObject Wire11;
    // Start is called before the first frame update
    void OnMouseDown()
    {
        TheDeleteWireButton11.SetActive(false);
        Wire11.SetActive(false);
    }

}
