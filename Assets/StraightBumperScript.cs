using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StraightBumperScript : MonoBehaviour{
    public float power = 300f;
    public float top = 1.0f;
    public float right = 1.0f;
    public int scoreValue= 100;
    List<Rigidbody> ballList;

    private void OnTriggerEnter (Collider other) {
        if (other.gameObject.CompareTag ("Ball")) {
            Rigidbody r = other.gameObject.GetComponent<Rigidbody> ();
            Vector3 myVector = new Vector3(top, 0.0f, right).normalized;
            r.velocity = Vector3.zero;
            r.angularVelocity = Vector3.zero;
            r.AddForce (power * myVector);
            ScoreManager.score += PointsManager.multiplier * scoreValue;
        }
    }
}