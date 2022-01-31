using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JohnTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.LogWarning($"Hello Trigger ${other.gameObject.name}");
    }
}
