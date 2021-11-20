using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{

    [SerializeField] private KeyType keyType;

    


    void Start()
    {

    }

    
    public enum KeyType
    {
        Door1,
        Door2,
        Door3,
        Door4
    }
    
    public KeyType GetKeyType()
    {
        return keyType;
    }
}
