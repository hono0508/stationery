using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GatyaScript : MonoBehaviour
{
    public Animator anime;

    public GameObject secen1;

    public GameObject secen10;

    public GameObject koumoku;

    public Text text;

    [SerializeField] public GameObject[] icon;


    GatyaScript gatya;

    private Transform MainPanel;

    private Transform SubPanel;

    public void Onecount(){
        string[] name = { "シャーペン", "ボールペン", "万年筆", "鉛筆", "ノリ", "コンパス", "定規", "フリクション", };
        int item = Random.Range(0, 8);

        if (seatus.money < 100)
        {
            secen1.SetActive(false);
            secen10.SetActive(false);
            text.text = "お金が足りないよ！";
            Debug.Log("No money");

        }
        else
        {
            seatus.money -= 100;
            seatus.itemcount[item]++;
            text.text = name[item] + "をゲット！！";

            secen1.SetActive(true);
            secen10.SetActive(false);
        }
        scene();

        for (int i = 0; i < icon.Length; i++)
            for (int j = 0; j < seatus.itemcount[i]; j++)
        {
            if (i < 4)
                Instantiate(icon[i], Vector3.zero, Quaternion.identity, MainPanel);
            else
                Instantiate(icon[i], Vector3.zero, Quaternion.identity, SubPanel);
        }

       



    }

    public void fivecount()
    {
        text.text = "";
        string[] name = { "シャーペン", "ボールペン", "万年筆", "鉛筆", "ノリ", "コンパス", "定規", "フリクション", };

        for (int i = 0; i < 5; i++)
        {
            int item = Random.Range(0, 8);
            if (seatus.money < 500)
            {
                secen1.SetActive(false);
                secen10.SetActive(false);
                text.text = "お金が足りないよ！";
                Debug.Log("No money");
            }else
            {
                seatus.money -= 500;
                seatus.itemcount[item]++;
                seatus.itemcount[item]++;

                if (i % 3 == 0)
                {
                    text.text += name[item] + "をゲット！！\n";
                }
                else
                {
                    text.text += name[item] + "をゲット！！ ";
                }
                secen1.SetActive(false);
                secen10.SetActive(true);
            }

        }

        scene();
    
       
    }

    // Start is called before the first frame update
    void Start()
    {
        gatya = GameObject.Find("gatya scene").GetComponent<GatyaScript>();

       anime = anime.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void scene()
    {
        anime.SetTrigger("gatya Trigger");


    }
    public void buck()
    {
        anime.SetTrigger("buck Trigger");

      
    }


    


}
