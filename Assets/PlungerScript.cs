using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlungerScript : MonoBehaviour {
    float power;
    float minPower = 0f;
    public float maxPower = 100f;
    public Slider powerSlider;
    List<Rigidbody> ballList;
    bool ballReady;
    public Object plunger;

    // Start is called before the first frame update
    void Start () {
        powerSlider.minValue = 0f;
        powerSlider.maxValue = maxPower;
        ballList = new List<Rigidbody>();
    }

    // Update is called once per frame
    void Update () {

        if (ballReady) {
            powerSlider.gameObject.SetActive(true);
        } else {
            powerSlider.gameObject.SetActive(false);
        }

        powerSlider.value = power;
        transform.position = new Vector3(4.25f,0.25f,-6.3f - power/3000);
        if (ballList.Count > 0) {
            ballReady = true;
            if (Input.GetKey (KeyCode.Space)) {
                if (power <= maxPower) {
                    power += 500 * Time.deltaTime;
                }
            }
            if (Input.GetKeyUp (KeyCode.Space)) {
                foreach (Rigidbody r in ballList) {
                    r.AddForce (power * Vector3.forward);
                    power = 0f;
                }
            }
        } else {
            ballReady = false;
            power = 0f;
        }
    }

    private void OnTriggerEnter (Collider other) {
        if (other.gameObject.CompareTag ("Ball")) {
            ballList.Add (other.gameObject.GetComponent<Rigidbody> ());
            CameraManager.cameraPosition = 1;
        }
    }
    private void OnTriggerExit (Collider other) {
        if (other.gameObject.CompareTag ("Ball")) {
            ballList.Remove (other.gameObject.GetComponent<Rigidbody> ());
            CameraManager.cameraPosition = 0;
        }
    }
}