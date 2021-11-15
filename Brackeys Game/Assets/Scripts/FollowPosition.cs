using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPosition : MonoBehaviour
{
    [SerializeField] Transform objectToFollow;

    [Header("Position")]
    [SerializeField] bool followXPos = true;
    [SerializeField] bool followYPos = true;
    [SerializeField] bool followZPos = true;

    [SerializeField] float relativeXPos;
    [SerializeField] float relativeYPos;
    [SerializeField] float relativeZPos;

    [Header("Rotation")]
    [SerializeField] bool followXRot;
    [SerializeField] bool followYRot;
    [SerializeField] bool followZRot;

    [SerializeField] int relativeXRot;
    [SerializeField] int relativeYRot;
    [SerializeField] int relativeZRot;

    void Update()
    {
        Vector3 newPosition = objectToFollow.position;
        if (followXPos)
            newPosition.x += relativeXPos;
        if (followYPos)
            newPosition.y += relativeYPos;
        if (followZPos)
            newPosition.z += relativeZPos;
        transform.position = newPosition;
    }
}
