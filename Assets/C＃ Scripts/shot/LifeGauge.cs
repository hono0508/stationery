using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeGauge : MonoBehaviour
{

    public static int resultmessage;

    //　ライフゲージプレハブ
    [SerializeField]
    private GameObject lifeObj;

    //intで残機上限
    private int LifeMax = 3;

    // Start is called before the first frame update
    void Start()
    {
        //　初め0;にHPを5にする
        for (int i = 0; i < LifeMax; i++)
        {
            Instantiate<GameObject>(lifeObj, transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //0になったらGameovereにする
        if (transform.childCount == 0)
        {
            SceneManager.LoadScene("result");
    
        }
    }

        //死亡数をカウントする



        //一人が死んだら１減らす

        public void Dead()
        { Destroy(transform.GetChild(0).gameObject); } 
}


