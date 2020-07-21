using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seatus: MonoBehaviour
{
    public static float atack;

    public static float defence;

    public static string name;

    // 0:シャーペンLv1,100,100　1:ボールペンLv1,120.80　2:万年筆Lv1,80,120　3:鉛筆Lv1,100,100　4:ノリLv1,10,10　5:コンパスLv1,10,10　6：定規Lv1,10,10　7:フリクションLv1,10,10

    // 8:シャーペンLv2,120,100 9:ボールペンLv2,130,90 10:万年筆Lv2,90,130 11:鉛筆Lv2,100,120 12:ノリLv2,20,20 13:コンパスLv2 14:定規,20,20 15:フリクションLv2,20,20

    //16:シャーペンLv3,130,110 17:ボールペンLv3,140,100 18:万年筆Lv3,100,140 19:鉛筆Lv3,110,130 20:ノリLv3,30,30 21:コンパスLv3,30,30 22:定規Lv3,30,30 23:フリクションLv3,30,30　

    public static int[] itemcount = new int[24];

    public static int[] armor = new int[4] {24, 24, 24, 24};  //24は装備なし

    public static int money;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
