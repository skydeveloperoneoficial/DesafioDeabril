﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedraBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Game Over");
            Destroy(gameObject, 3);

        }
    }
}
