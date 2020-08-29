using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aitemuaikon : MonoBehaviour
{

    //アイテム耐久値
     public  float taikyu = 10f;

    //プレイヤーへの防御力付与
    public float defence = 100f;

    //プレイヤーHP
    public float hp = 100f;

    //プレイヤー攻撃力
    public float attack = 10f;

    public void SetArmor()
    {
        seatus.atack += attack;
        seatus.defence += defence;
    }

    public void UnArmor()
    {
        seatus.atack -= attack;
        seatus.defence -= defence;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
}
