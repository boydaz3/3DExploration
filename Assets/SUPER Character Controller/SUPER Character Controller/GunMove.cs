using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class GunMove : MonoBehaviour
{
    public float armRotationSpeed = 5f;
    public float delayBeforeArmsMove = 2f;

    void Start()
    {
        StartCoroutine(MoveArmsWithDelay());
    }

    IEnumerator MoveArmsWithDelay()
    {
        yeild return new WaitForSeconds(delayBeforeArmsMove);

        while(true)
    }

    void Update()
    {
        if (main.camra != null)
        { 
        Vector3D
0        
        }

    }
}
