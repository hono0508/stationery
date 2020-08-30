using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{

    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        //  InvokeRepeating("enemyspon", 1, 5);

        for (int e = 1; e <= 4; e++)
        {
            Instantiate(enemy, new Vector3(Random.Range(10.0f,-2.5f), 12,0), Quaternion.identity);

            GameObject player = GameObject.Find("ThirdPersonController");

        }
    }
   // void enemyspon()
   // {
   //     Instantiate(enemy, transform.position, transform.rotation);
  //  }
    // Update is called once per frame
    void Update()
    {
    
    }
}
    

