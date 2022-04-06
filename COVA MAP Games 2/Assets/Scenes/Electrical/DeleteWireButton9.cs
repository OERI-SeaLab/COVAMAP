using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteWireButton9 : MonoBehaviour
{
    public GameObject TheDeleteWireButton9;
    public GameObject Wire9;
    // Start is called before the first frame update
    void OnMouseDown()
    {
        TheDeleteWireButton9.SetActive(false);
        Wire9.SetActive(false);
    }

}
