using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour
{

    public List<string> items;
    //public static int i = 3;

    // Start is called before the first frame update
    void Start()
    {
        items = new List<string>();
    }

    // Update is called once per frame
   

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Mask"))
        {
            
            string itemType = collider.gameObject.GetComponent<collectablescript>().itemType;
            Debug.Log("Yes" + itemType);
            items.Add(itemType);
            Score.Maskscore = Score.Maskscore + 1;
            Debug.Log("length:" +items.Count);

            Destroy(collider.gameObject);
        }

       else if (collider.CompareTag("Medicine"))
        {

            string itemType = collider.gameObject.GetComponent<collectablescript>().itemType;
            Debug.Log("Yes" + itemType);
            items.Add(itemType);
            Score2.Medscore = Score2.Medscore + 1;
            Debug.Log("length:" + items.Count);

            Destroy(collider.gameObject);
        }

        else if (collider.CompareTag("Oxygen"))
        {

            string itemType = collider.gameObject.GetComponent<collectablescript>().itemType;
            Debug.Log("Yes" + itemType);
            items.Add(itemType);
            Score3.Oxygenscore = Score3.Oxygenscore + 1;
            Debug.Log("length:" + items.Count);

            Destroy(collider.gameObject);
        }
    }

}
