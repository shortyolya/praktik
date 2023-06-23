using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject objects;
    void Start()
    {
        InvokeRepeating("CreateObjects", 1,1);
    }

    
    void CreateObjects()
    {
        Instantiate(objects, new Vector3(15f, 0f, 0) , Quaternion.identity);
    }
}
