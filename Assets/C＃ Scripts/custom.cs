using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class custom : MonoBehaviour
{
    [SerializeField] public Button[] Flame;
    public kasutamu kstm;
    private int selectnumber;
    public GameObject inventory;
    public henseiselect close;

    // Start is called before the first frame update


    void Start()
    {
        seatus.itemcount[1] = 5;
        for (int i = 0; i < seatus.armor.Length; i++)
        {

            if (seatus.armor[i] != 24)
            {
                Flame[i].image.sprite = kstm.icon[seatus.armor[i]].GetComponent<Button>().image.sprite;
            }

        }
    }

    // Update is called once per frame
    void Update()
    {

    }




    public void OnClickFlame(int number)
    {
           // inventory.SetActive(true);
            selectnumber = number;
    }

    public void changeImage(int itemnumber)
    {

        Flame[selectnumber-1].image.sprite = kstm.icon[itemnumber].GetComponent<Button>().image.sprite;
        Debug.Log(itemnumber);
        Debug.Log(selectnumber);

        if (seatus.armor[selectnumber-1] != 24)
        {
            seatus.itemcount[seatus.armor[selectnumber-1]]++;
        }
        if (seatus.armor[selectnumber - 1] !=24){
            seatus.itemcount[seatus.armor[selectnumber - 1]]++;
            kstm.icon[itemnumber].GetComponent<aitemuaikon>().UnArmor();
        }
        seatus.armor[selectnumber - 1] = itemnumber;
        seatus.itemcount[itemnumber]--; //選択したアイテムを減らす
        kstm.icon[itemnumber].GetComponent<aitemuaikon>().SetArmor();

        //ボタンの子供であるTextを取得、非表示に
        if (Flame[selectnumber-1].gameObject.transform.Find("Text"))
            Flame[selectnumber-1].gameObject.transform.Find("Text").gameObject.SetActive(false);

        selectnumber = 0;
        //inventory.SetActive(false);

        close.close();
    }
}

