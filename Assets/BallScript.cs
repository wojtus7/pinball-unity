using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < -10 && LivesManager.lives > 0) {
            LivesManager.lives -= 1;
            if (LivesManager.lives > 0) {
                GetComponent<Rigidbody>().velocity = Vector3.zero;
                GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
                transform.position = new Vector3(4.24f, 0.26f, -4.95f);
            }
        }
    }
}
