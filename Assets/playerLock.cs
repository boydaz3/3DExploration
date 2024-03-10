using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerLock : MonoBehaviour
{
    public GameObject player;
    // Update is called once per frame
    void Update()
    {
        Vector3 particlePos =
            new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z);
        transform.position = particlePos;
    }
}
