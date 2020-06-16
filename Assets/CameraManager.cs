using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour {
    public static int cameraPosition;
    float interpolator = 1f;
    float interpolator2 = 0f;
    bool transitionOver = false;
    bool duringTransition = false;

    Vector3 gameCamera = new Vector3 (0f, 11.4f, -6.6f);
    Vector3 bigGameCamera = new Vector3 (0f, 15f, -6f);
    Vector3 plungerCamera = new Vector3 (2.45f, 8.72f, -7.54f);

    float additionalY = 3.6f;
    float additionalZ = 0.6f;

    // Start is called before the first frame update
    void Awake () {
        cameraPosition = 1;
    }

    // Update is called once per frame
    void Update () {
        Vector3 destinatedPlace;

        if (DoorManager.openCount <= 0) {
            if (interpolator2 < 1f) {
                interpolator2 += 0.005f;
            }
        }

        destinatedPlace = new Vector3 (0f, 11.4f + (additionalY * interpolator2), -6.6f + (additionalZ * interpolator2));
        
        if (cameraPosition == 0) {
            if (interpolator < 1f) {
                interpolator += 0.005f;
            }
        } else if (cameraPosition == 1) {
            if (interpolator > 0f) {
                interpolator -= 0.005f;
            }
        }
            transform.position = Vector3.Lerp (plungerCamera, destinatedPlace, interpolator);
    }
}