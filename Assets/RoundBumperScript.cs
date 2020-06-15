using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundBumperScript : MonoBehaviour{
    public float power = 300f;
    public int scoreValue = 50;
    List<Rigidbody> ballList;

    private void OnTriggerEnter (Collider other) {
        if (other.gameObject.CompareTag ("Ball")) {
            Rigidbody r = other.gameObject.GetComponent<Rigidbody> ();
            Vector3 myVector = other.transform.position - transform.position;
            myVector.y = 0;
            r.velocity = Vector3.zero;
            r.angularVelocity = Vector3.zero;
            r.AddForce (power * myVector.normalized);
            ScoreManager.score += scoreValue;
        }
    }
}