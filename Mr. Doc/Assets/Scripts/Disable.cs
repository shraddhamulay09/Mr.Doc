using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Disable : MonoBehaviour
{
    //Text patient1;
      


    void Start()
    {
       // patient1 = GetComponent<Text>();
         

    }

    void Update()
    {
       

    }

    public void whenMaskButtonClicked()
    {
        if (Score.Maskscore > 0)
        {
            //playerscript.i = playerscript.i - 1;
            Destroy(gameObject);
           
            Score.Maskscore--;
           // isRecovered();

        }
       


    }

    public void whenMedButtonClicked()
    {
        if (Score2.Medscore > 0)
        {
            //playerscript.i = playerscript.i - 1;
            Destroy(gameObject);
            
            Score2.Medscore--;
            //isRecovered();

        }


    }

    public void whenOxygenButtonClicked()
    {
        if (Score3.Oxygenscore > 0)
        {
           // playerscript.i = playerscript.i - 1;
            Destroy(gameObject);
            Score3.Oxygenscore--;
            //isRecovered();

        }


    }

    /*public void isRecovered()
    {
        Debug.Log(playerscript.i);
        if (playerscript.i == 0)
        {
            patient1.text = "Patient Recovered";
        }
    }*/
     
    
}
