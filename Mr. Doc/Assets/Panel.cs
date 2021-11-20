using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Panel : MonoBehaviour
{
    public static int n = 12;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(n==0)
        {
            Debug.Log("Win");
            SceneManager.LoadScene(1);
        }
        Debug.Log(n);
    }
}
