using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score4 : MonoBehaviour
{
    public static int key = 0;

    Text score4;

    // Start is called before the first frame update
    void Start()
    {
        score4 = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        score4.text = "Key: " + key;

    }
}
