﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
    // Start is called before the first frame update
    private void win1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -2);
    }
    void Start()
    {
        Invoke("win1", 5f); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
