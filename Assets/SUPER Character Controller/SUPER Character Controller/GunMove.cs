using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class GunMove : MonoBehaviour
{
    public float rotationSpeed = 5f;
    public float dampingFactor = 5f;
    public float delayBeforeMovement = 5f;

    private Transform playerCamera;

    void Start()
    {
        playerCamera = Camera.main.transform;
        StartCoroutine(DelayedGunMovement());
    }
    
    IEnumerator DelayedGunMovement()
    {
        yield return new WaitForSeconds(delayBeforeMovement);
            Vector3 targetDirection = playerCamera.forward;
            Quaternion targetRotation = Quaternion.LookRotation(targetDirection, Vector3.up);

            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotationSpeed / dampingFactor);
    }
}
