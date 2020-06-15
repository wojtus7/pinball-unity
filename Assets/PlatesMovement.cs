using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatesMovement : MonoBehaviour {
    public float speed = 20.0f;
    public bool rightHand = false;
    public bool leftHand = false;

    public float maxDegree = 1.0f;

    float destinatedDegree = 0.0f;

    // Start is called before the first frame update
    void Start () {
        transform.Rotate (0.0f, 0.0f, -speed);
    }

    // Update is called once per frame
    void Update () {
        if (leftHand) {
            if (leftHand && Input.GetButtonDown ("Fire1")) {
                destinatedDegree = maxDegree;
            } else if (leftHand && Input.GetButtonUp ("Fire1")) {
                destinatedDegree = 0.0f;
            }

            if (destinatedDegree > transform.rotation.z && destinatedDegree > 0.0f) {
                transform.Rotate (0.0f, 0.0f, speed);
            } else if (transform.rotation.z >= 0.0f && destinatedDegree == 0.0f) {
                transform.Rotate (0.0f, 0.0f, -speed);
            }
        }
        if (rightHand) {
            if (Input.GetButtonDown ("Fire2")) {
                destinatedDegree = maxDegree;
            } else if (Input.GetButtonUp ("Fire2")) {
                destinatedDegree = 0.0f;
            }

            if (destinatedDegree > transform.rotation.x && destinatedDegree > 0.0f) {
                transform.Rotate (0.0f, 0.0f, speed);
            } else if (transform.rotation.x >= 0.0f && destinatedDegree == 0.0f) {
                transform.Rotate (0.0f, 0.0f, -speed);
            }
        }
    }
}