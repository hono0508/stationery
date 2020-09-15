using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GatyaScript : MonoBehaviour
{
    public Animator anime;

    public GameObject one;

    public GameObject five;

    public GameObject nomoney1;

    public GameObject nomoney5;

    public GameObject returnone;

    public GameObject returnfive;
    public GameObject panel;


    [SerializeField] public GameObject[] icon;

    public AudioClip soundnormal;

    public AudioClip soundmoney;

    AudioSource audioSource;

    public Text moneytext;

    public Camera subcamera;

    GatyaScript gatya;

    private Transform MainPanel;

    private Transform SubPanel;

    public void Onecount()
    {
        string[] name = { "シャーペン", "ボールペン", "万年筆", "鉛筆", "ノリ", "コンパス", "定規", "フリクション", };
        int item = Random.Range(0, 8);

        if (seatus.money < 100)
        {
            one.SetActive(false);
            nomoney1.SetActive(true);
            Debug.Log("No money");

        }
        else
        {
            panel.SetActive(true);
            anime.SetTrigger("gatya Trigger");
            //subcamera.gameObject.SetActive(true);
            seatus.money -= 100;
            seatus.itemcount[item]++;
            moneytext.text = seatus.money.ToString();

            if (seatus.money < 100)
            {
                returnone.SetActive(false);

                Debug.Log("No money");
            }
            else
            {
                returnone.SetActive(true);

            }
        }


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

        string[] name = { "シャーペン", "ボールペン", "万年筆", "鉛筆", "ノリ", "コンパス", "定規", "フリクション", };

        for (int i = 0; i < 5; i++)
        {
            int item = Random.Range(0, 8);
            if (seatus.money < 500)
            {
                five.SetActive(false);
                nomoney5.SetActive(true);
                Debug.Log("No money");
            }
            else
            {
                panel.SetActive(true);
                //subcamera.gameObject.SetActive(true);
                seatus.money -= 500;
                seatus.itemcount[item]++;
                seatus.itemcount[item]++;

                if (i % 3 == 0)
                {

                }
                else
                {

                }
                moneytext.text = seatus.money.ToString();

                if (seatus.money < 500)
                {
                    returnfive.SetActive(false);
                    Debug.Log("No money");
                }
                else
                {
                    anime.SetTrigger("gatya Trigger");
                    returnfive.SetActive(true);
                }

            }




        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //  gatya = GameObject.Find("gatya scene").GetComponent<GatyaScript>();

        anime = anime.GetComponent<Animator>();



        nomoney1.SetActive(false);

        nomoney5.SetActive(false);

        moneytext.text = seatus.money.ToString();
        Debug.Log(seatus.money);

        audioSource = GetComponent<AudioSource>();






    }

    // Update is called once per frame
    void Update()
    {

    }




    public void back()
    {
        // subcamera.gameObject.SetActive(false);
        //one.SetActive(false);
        //nomoney1.SetActive(false);
        //five.SetActive(false);
        //nomoney5.SetActive(false);
        panel.SetActive(false);
    }


}