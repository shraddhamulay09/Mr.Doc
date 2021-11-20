using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panelfollow : MonoBehaviour
{

    private Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

    }

    void LateUpdate()
    {
        //we store current position of camera in variable temp
        Vector3 temp = transform.position;

        //we set the camera position x to be equal to the player position x
        temp.x = playerTransform.position.x+7.5f;

        //we set the camera position y to be equal to the player position y
        temp.y = playerTransform.position.y+3.8f;

        //we set back the camera temp position to camera current position
        transform.position = temp;
    }
}
