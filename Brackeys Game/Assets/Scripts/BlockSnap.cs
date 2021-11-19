using UnityEditor;
using UnityEngine;

[ExecuteInEditMode]
public class BlockSnap : MonoBehaviour
{
    [SerializeField] float gridSize = 1f;

    void Update()
    {
        if (EditorApplication.isPlaying) return;

        float x = transform.position.x - transform.position.x % gridSize;
        float y = transform.position.y - transform.position.y % gridSize;
        float z = transform.position.z - transform.position.z % gridSize;

        Vector3 newPos = new Vector3(x, y, z);
        transform.position = newPos;
    }
}
