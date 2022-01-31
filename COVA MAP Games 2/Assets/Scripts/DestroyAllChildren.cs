using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Destroy the children of the panel which only contains the incorrect/correct instantiated prefabs.

public class DestroyAllChildren : MonoBehaviour
{
    //Game object array for the children of the panel which contains the instantiated prefabs.
    public GameObject[] ChildrenToDestroy;
    
    public void DestroyChildren()
    {
        ChildrenToDestroy = new GameObject[transform.childCount];     
        for (int i = 0; i < transform.childCount; i++)    
            {
                ChildrenToDestroy[i] = transform.GetChild(i).gameObject;  //Add the children the the array
            }
        
        foreach(GameObject go in ChildrenToDestroy)  //Kill the children.
            {
                Destroy(go);
            }
    }
}
