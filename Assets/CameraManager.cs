using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour {
    public static int cameraPosition;
    // Start is called before the first frame update
    void Awake () {
        cameraPosition = 0;
    }

    // Update is called once per frame
    void Update () {
        if (cameraPosition == 0) {
            if (DoorManager.openCount <= 0) {
                transform.position = new Vector3 (0f, 15f, -6f);
            } else {
                transform.position = new Vector3 (0f, 11.4f, -6.6f);
            }
        } else if (cameraPosition == 1) {
            transform.position = new Vector3 (2.45f, 8.72f, -7.54f);
        }
    }
}