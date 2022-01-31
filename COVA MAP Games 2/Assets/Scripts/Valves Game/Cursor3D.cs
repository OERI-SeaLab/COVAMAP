using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor3D : MonoBehaviour
{
    public Collider planeCollider;
    public Camera CursorCamera;
    public static Vector3 Position;

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        bool didCast = planeCollider.Raycast(ray, out RaycastHit hitInfo, Mathf.Infinity);

        if (didCast)
        {
            transform.position = hitInfo.point;
            Position = hitInfo.point;
        }
    }
}
