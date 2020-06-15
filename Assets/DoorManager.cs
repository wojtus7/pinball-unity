using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    public static int openCount;

    void Awake()
    {
        openCount = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (openCount <= 0) {
            transform.position = new Vector3(0, -1, 0);
        }
    }
}
