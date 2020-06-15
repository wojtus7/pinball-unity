using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public int scoreValue = 50;

     private void OnTriggerEnter (Collider other) {
        var cubeRenderer = GetComponent<Renderer>();
        if (other.gameObject.CompareTag ("Ball") && cubeRenderer.material.color != Color.red) {
            DoorManager.openCount -= 1;
            cubeRenderer.material.SetColor("_Color", Color.red);
            ScoreManager.score += scoreValue;
        }
    }
}
