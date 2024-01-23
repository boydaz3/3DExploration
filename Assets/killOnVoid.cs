using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killOnVoid : MonoBehaviour
{
    public float yVoidLevel = -100f;

    public Vector3 resetPos = Vector3.zero;

    public Boolean setToSceneStartPosition = true;
    
    private void Start()
    {
        if (setToSceneStartPosition)
        {
            resetPos = gameObject.transform.position;
        }
    }

    void Update()
    {
        if (gameObject.transform.position.y < yVoidLevel)
        {
            gameObject.transform.position = resetPos;
        }  
    }
}
