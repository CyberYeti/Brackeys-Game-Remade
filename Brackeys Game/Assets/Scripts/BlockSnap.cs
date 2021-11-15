using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class BlockSnap : MonoBehaviour
{
    [SerializeField] float gridSize = 1f;

    void Update()
    {
        float x = transform.position.x - transform.position.x % gridSize;
        float y = transform.position.y - transform.position.y % gridSize;
        float z = transform.position.z - transform.position.z % gridSize;

        Vector3 newPos = new Vector3(x, y, z);
        transform.position = newPos;
    }
}
