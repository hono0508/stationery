using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    float interval = 5.0f;
    float timer = 0;
    public GameObject enemy;
    public GameObject[] enemyLooks;

    // Start is called before the first frame update
    void Start()
    {
        //  InvokeRepeating("enemyspon", 1, 5);

        for (int e = 1; e <= 4; e++)
        {
            int enemyL = Random.Range(0, enemyLooks.Length); //見た目をランダムにする
            Transform ene = Instantiate(enemy, new Vector3(Random.Range(10.0f, -2.5f), -1, 0), Quaternion.identity).transform;
            Instantiate(enemyLooks[enemyL], ene.position, Quaternion.identity, ene);

        }
    }
   // void enemyspon()
   // {
   //     Instantiate(enemy, transform.position, transform.rotation);
  //  }
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > interval)
        {
            float posX = Random.Range(-16, 27); //位置をランダムにする
            float posZ = Random.Range(-10, 17); //位置をランダムにする
            int enemyL = Random.Range(0, enemyLooks.Length); //見た目をランダムにする

            Transform e = Instantiate(enemy, new Vector3(posX, -1, posZ), Quaternion.identity).transform;
            Instantiate(enemyLooks[enemyL], e.position, Quaternion.identity, e);

            timer = 0; //タイマーをリセットする
        }
    
}
}
    

