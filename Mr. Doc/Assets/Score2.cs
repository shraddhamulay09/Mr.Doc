using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score2 : MonoBehaviour
{
    public static int Medscore = 0;

    Text score2;

    // Start is called before the first frame update
    void Start()
    {
        score2 = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        score2.text = "Medicine: " + Medscore;

    }
}
