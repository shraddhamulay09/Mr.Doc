using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupItem : MonoBehaviour
{

    [SerializeField] private Text text;

    public GameObject[] inventory = new GameObject[10];

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
            {
           
            Debug.Log("yes");
            
            pickUp();
           

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name.Equals("Mr.Doc"))
        {
            text.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Mr.Doc"))
        {
            text.gameObject.SetActive(false);
        }
    }

    private void pickUp()
    {
        Debug.Log("yeees");
        AddItem(gameObject);
        Destroy(gameObject);
        
    }

    public void AddItem(GameObject gameObject)
    {
        for (int i= 0; i < inventory.Length; i++)
            {
            if (inventory[i] == null)
            {
                inventory[i] = gameObject;
                Debug.Log(gameObject.name + " was added");
                break;
            }
        }
    }
}
