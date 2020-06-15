using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public int scoreValue = 50;
    public int typeOfButton = 0;

     private void OnTriggerEnter (Collider other) {
        var cubeRenderer = GetComponent<Renderer>();
        if (other.gameObject.CompareTag ("Ball") && cubeRenderer.material.color != Color.green && typeOfButton == 0) {
            DoorManager.openCount -= 1;
            cubeRenderer.material.SetColor("_Color", Color.green);
            ScoreManager.score += PointsManager.multiplier *  scoreValue;
        } else if (other.gameObject.CompareTag ("Ball") && typeOfButton == 1 ) {
            if ( cubeRenderer.material.color != Color.red && PointsManager.multiplier == 1 ) {
                cubeRenderer.material.SetColor("_Color", Color.red);
                PointsManager.multiplierCunter += 1;
            } else if (cubeRenderer.material.color != Color.yellow && PointsManager.multiplier == 2 ) {
                cubeRenderer.material.SetColor("_Color", Color.yellow);
                PointsManager.multiplierCunter += 1;
            } else if (cubeRenderer.material.color != Color.green && PointsManager.multiplier == 3 ) {
                cubeRenderer.material.SetColor("_Color", Color.green);
                PointsManager.multiplierCunter += 1;
            }
        }
    }
}
