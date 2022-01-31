using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Dress the COVA Map character based on the active images in the grid.  

public class Dress : MonoBehaviour
{
    public GameObject[] dress;   //GameObject array of the PPE attached to the COVA Map character. 
    public GameObject[] check;   //GameObject array of the pictures the users choose.
    public int NumObjects;

    public void Start()  
    {
        NumObjects = dress.Length;

        for(int i = 0; i < NumObjects; i++)    //Check if the users chosen pictures are active and make the corresponding PPE items on the charater active/inactive.
            if (check[i].activeInHierarchy == true)
                dress[i].SetActive(true);
            else if (check[i].activeInHierarchy == false)
                dress[i].SetActive(false);
    }

    public void DetectPPE()    //With each click the user makes, again check if the users chosen pictures are active and make the corresponding PPE items on the charater active/inactive.
    {
        for(int i = 0; i < NumObjects; i++)
            if (check[i].activeInHierarchy == true)
                dress[i].SetActive(true);
            else if (check[i].activeInHierarchy == false)
                dress[i].SetActive(false);
    }
}
