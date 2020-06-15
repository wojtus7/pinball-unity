using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesManager : MonoBehaviour
{
   public static int lives;

    Text text;
    // Start is called before the first frame update
    void Awake()
    {
        text = GetComponent <Text> ();
        lives = 3;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Lives: " + lives;
    }
}
