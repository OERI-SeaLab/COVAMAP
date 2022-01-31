using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValveSpot : MonoBehaviour
{
    [System.Serializable]
    public struct CorrectValveStruct
    {
        public string name;
        public GameObject correctValve;
        public GameObject objectToEnable;
    }

    public bool Contains(GameObject correctValve, out CorrectValveStruct result)
    {
        for (int i = 0; i < correctValveObjects.Count; i++)
        {
            if (correctValveObjects[i].correctValve == correctValve)
            {
                result = correctValveObjects[i];
                return true;
            }
        }
        result = default;
        return false;
    }

    //public List<GameObject> correctValves;

    public List<CorrectValveStruct> correctValveObjects;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
