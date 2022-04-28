using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom2 : MonoBehaviour
{
    public GameObject Bundle2B;
    public GameObject Bundle3B;
    public GameObject Bundle4B;

    // Start is called before the first frame update
    void Start()
    {

        Bundle2B.SetActive(false);
        Bundle3B.SetActive(false);
        Bundle4B.SetActive(false);

    }

    // Update is called once per frame

    private void OnMouseDown()
    {
        Bundle2B.SetActive(true);
        Bundle3B.SetActive(false);
        Bundle4B.SetActive(false);
    }

}