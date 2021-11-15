using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float forwardForce = 10f;
    [SerializeField] float maxForwardVelocity = 10f;
    [SerializeField] float horizontalForce = 15f;

    Rigidbody rb;
    float forwardVelocity = 0f;
    bool gotLeftInput = false;
    bool gotRightInput = false;

    private void Awake()
    {
        rb = transform.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        #region Player Inputs
        //Left Input
        if (Input.GetKey(KeyCode.A))
            gotLeftInput = true;
        else
            gotLeftInput = false;

        //Right Input
        if (Input.GetKey(KeyCode.D))
            gotRightInput = true;
        else
            gotRightInput = false;
        #endregion
    }

    void FixedUpdate()
    {
        #region Forward Movement
        forwardVelocity = rb.velocity.z;
        float maxSpeedFactor = Mathf.Clamp(maxForwardVelocity - forwardVelocity, 0, 1);
        Vector3 forwardAddedForce = Vector3.forward * forwardForce * maxSpeedFactor;
        rb.AddForce(forwardAddedForce, ForceMode.Force);
        #endregion

        #region Sideways Movement
        Vector3 horizontalAddedForce = Vector3.zero;
        if (gotLeftInput)
            horizontalAddedForce += Vector3.left * horizontalForce;
        if (gotRightInput)
            horizontalAddedForce += Vector3.right * horizontalForce;
        rb.AddForce(horizontalAddedForce, ForceMode.Force);
        #endregion
    }
}
