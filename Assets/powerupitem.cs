﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class powerupitem : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void kyokaAction(int itemnumber)
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "kyoka")
        {
            GameObject.Find("Powerupmanager").gameObject.GetComponent<powerup>().changeImage(itemnumber);
        }
    }
}

        
    


        
    
        
    

    


