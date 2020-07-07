using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class powerup : MonoBehaviour
{

    int selectnumber = 0;

    public GameObject inventory;

    [SerializeField] public Button[] Flame;

    int itemnumber6 = 0;

    public kasutamu kstm;

    // Start is called before the first frame update
    void Start()
    {
        inventory.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClickFlame(int number) {
        if (selectnumber == 0)
        {
            inventory.SetActive(true);
            selectnumber = number;

        }
    }

    public void changeImage(int itemnumber)
    {
         Flame [selectnumber - 1 ].image.sprite = kstm.icon[itemnumber].GetComponent<Button>().image.sprite;

        //ボタンの子供であるTextを取得、非表示に
        Flame[selectnumber - 1].gameObject.transform.Find("Text").gameObject.SetActive(false);

        //ログに選択した素材の表示
        // Debug.Log(kstm.icon[itemnumber].GetComponent<Button>().image);

        if (selectnumber == 6)
        {
            itemnumber6 = itemnumber;
        }
        selectnumber = 0;
        inventory.SetActive(false);

    }

    public void PowerupBotton()
    {
        for (int f = 0; f < Flame.Length; f++)
        {
            if (Flame[5] != Flame[f])
            { 
                Debug.Log("合成できません");
                return;
            }
        }

        seatus.itemcount[itemnumber6] -= 5;
        seatus.itemcount[itemnumber6 + 8] += 1;
        Reset();
    }

    public void Reset()
    {
        for (int f = 0; f < Flame.Length; f++)
        {
           selectnumber = 0;

        }
    }
}


        
    
        
    

    


