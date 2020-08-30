using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;


public class LifeGauge : MonoBehaviour
{
    //レーダーの宣言
    [SerializeField] Transform enemypoint;
    [SerializeField] Transform playerpoint;
    [SerializeField] Image center;
    [SerializeField] Image target;
    [SerializeField] float radarLength = 30f;
    public static int resultmessage;
    
    RectTransform rt;
    Vector2 offset;
    float r = 6f;

    public static float CountDownTime;
    public Text TextCountDown;


    public GameObject player;


    //　ライフゲージプレハブ
    [SerializeField]
    private GameObject lifeObj;

    //intで残機上限
    private int LifeMax = 3;

    // Start is called before the first frame update
    void Start()
    {
        CountDownTime = 60.0F;

        rt = target.GetComponent<RectTransform>();
        offset = center.GetComponent<RectTransform>().anchoredPosition;

        //　初め0;にHPを5にする
        for (int i = 0; i < LifeMax; i++)
        {
            Instantiate<GameObject>(lifeObj, transform);
        }

        
    }

    // Update is called once per frame
    void Update()
    {

        TextCountDown.text = String.Format("{0:00.00}", CountDownTime);
        CountDownTime -= Time.deltaTime;

        if (CountDownTime <= 0.0F)
        {
            CountDownTime = 0.0F;
            SceneManager.LoadScene("result");
        }

        Vector3 enemyDir = enemypoint.position;
        enemyDir.y = playerpoint.position.y; // プレイヤーと敵の高さを合わせる
        enemyDir = enemypoint.position - playerpoint.position;

        enemyDir = Quaternion.Inverse(playerpoint.rotation) * enemyDir; // ベクトルをプレイヤーに合わせて回転
        enemyDir = Vector3.ClampMagnitude(enemyDir, radarLength); // ベクトルの長さを制限

        rt.anchoredPosition = new Vector2(enemyDir.x * r + offset.x, enemyDir.z * r + offset.y);



        if (Input.GetKeyDown(KeyCode.E))
        {
            offset = center.GetComponent<RectTransform>().anchoredPosition;
        }

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


