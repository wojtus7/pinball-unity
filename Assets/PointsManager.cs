using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsManager : MonoBehaviour
{
    public static int multiplier;
    public static int multiplierCunter;

    Text text;
    // Start is called before the first frame update
    void Awake()
    {
        multiplierCunter = 0;
        multiplier = 1;
        text = GetComponent <Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        if (multiplierCunter >= 9) {
            multiplier = 4;
        } else if (multiplierCunter >= 6) {
            multiplier = 3;
        } else if (multiplierCunter >= 3) {
            multiplier = 2;
        } 
        text.text = "Multiplier: x" + multiplier;
    }
}
