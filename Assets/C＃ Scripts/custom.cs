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
        for (int i = 0; i < seatus.armor.Length; i++)
        {
            seatus.money = 10000;

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

        Flame[selectnumber].image.sprite = kstm.icon[itemnumber].GetComponent<Button>().image.sprite;

        //ボタンの子供であるTextを取得、非表示に
        Flame[selectnumber].gameObject.transform.Find("Text").gameObject.SetActive(false);

        selectnumber = 0;
        //inventory.SetActive(false);

        close.close();
    }
}

