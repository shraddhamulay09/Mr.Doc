using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score3 : MonoBehaviour
{
    public static int Oxygenscore = 0;

    Text score3;

    // Start is called before the first frame update
    void Start()
    {
        score3 = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        score3.text = "Oxygen: " + Oxygenscore;

    }
}
