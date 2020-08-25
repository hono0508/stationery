using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class powerup : MonoBehaviour
{

    int selectnumber = 0;
    public int[] selectedItemNums = new int[6];　//空の時は100

    public GameObject inventory;

    [SerializeField] public Button[] Flame;

    int itemnumber6 = 0;

    public kasutamu kstm;

    Image Image;

    [SerializeField]
    private Sprite sprite;

    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i<selectedItemNums.Length; i++)
        {
            selectedItemNums[i] = 100;
        }
        //サンプル　seatus.itemcount[0] = 5; 
        inventory.SetActive(false);
        Image = GetComponent<Image>();

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(seatus.itemcount[9]);

    }

    public void OnClickFlame(int number)
    {
        if (selectnumber == 0)
        {
            inventory.SetActive(true);
            selectnumber = number;

        }
    }

    public void changeImage(int itemnumber)
    {
        Flame[selectnumber - 1].image.sprite = kstm.icon[itemnumber].GetComponent<Button>().image.sprite;

        //ボタンの子供であるTextを取得、非表示に
        Flame[selectnumber - 1].gameObject.transform.Find("Text").gameObject.SetActive(false);

        //ログに選択した素材の表示
        // Debug.Log(kstm.icon[itemnumber].GetComponent<Button>().image);

        if (selectnumber == 6)
        {
            itemnumber6 = itemnumber;
        }

        if (selectedItemNums[selectnumber-1] != 100)
        {
            seatus.itemcount[selectedItemNums[selectnumber-1]]++;
        }
        selectedItemNums[selectnumber-1] = itemnumber; //選択しているアイテム番号を保存しておく
        seatus.itemcount[itemnumber]--; //選択したアイテムを減らす


        selectnumber = 0;
        inventory.SetActive(false);

    }

    public void PowerupBotton()
    {
        for (int f = 0; f < Flame.Length; f++)
        {
            if (Flame[5].image.sprite != Flame[f].image.sprite || Flame[5].image.sprite.name == "empty")
            {
                Debug.Log("合成できません");
                Reset();
                return;
            }
        }
        
        success();
    }

    public void success()
    {
        seatus.itemcount[itemnumber6] -= 5;
        seatus.itemcount[itemnumber6 + 8] += 1;
        Flame[5].image.sprite = kstm.icon[itemnumber6 + 8].GetComponent<Button>().image.sprite;
        for (int f = 0; f < Flame.Length - 1; f++)
        {
            selectnumber = 0;
            Flame[f].image.sprite = sprite;
        }
        Debug.Log("sucsess");
    }

    public void Reset()
    {
        Debug.Log("reset");

        for (int i = 0; i < selectedItemNums.Length; i++)
        {
            if(selectedItemNums[i] != 100)
            {
                seatus.itemcount[selectedItemNums[i]]++;
            }
            selectedItemNums[i] = 100;
        }

        for (int f = 0; f < Flame.Length; f++)
        {
            selectnumber = 0;
            Flame[f].image.sprite = sprite;
        }
    }
}



        
    
        
    

    


