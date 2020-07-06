﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject prefab;
   

    public float timeBetweenSpawns = 1f;
   private void Start()
    {
        InvokeRepeating("Spawn", 1f, timeBetweenSpawns);
    }
    void Spawn()
    { 
        float x = Random.Range(-9f, 9f);
        Vector3 position = new Vector3(x, transform.position.y, 0f);
        Instantiate(prefab, position, Quaternion.identity);
        
       
    }
   

}
