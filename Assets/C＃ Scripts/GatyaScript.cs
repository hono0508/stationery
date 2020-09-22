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


    [SerializeField] public kasutamu kstm;

    public AudioClip soundnormal;

    public AudioClip soundmoney;

    AudioSource audioSource;

    public Text moneytext;

    public Camera subcamera;

    GatyaScript gatya;

    public Transform panelContent;

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
            foreach (Transform n in panelContent.gameObject.transform)
            {
                GameObject.Destroy(n.gameObject);
            }
            panel.SetActive(true);
            returnfive.SetActive(false);
            anime.SetTrigger("gatya Trigger");
            //subcamera.gameObject.SetActive(true);
            seatus.money -= 100;
            seatus.itemcount[item]++;
            moneytext.text = seatus.money.ToString();

            Instantiate(kstm.icon[item], Vector3.zero, Quaternion.identity, panelContent);

            if (seatus.money < 100)
            {
                returnone.SetActive(false);
                one.SetActive(false);
                nomoney1.SetActive(true);
                Debug.Log("No money");
            }
            else
            {
                returnone.SetActive(true);

            }
        }
    }

    public void fivecount()
    {

        string[] name = { "シャーペン", "ボールペン", "万年筆", "鉛筆", "ノリ", "コンパス", "定規", "フリクション", };

        if (seatus.money < 500)
        {
            five.SetActive(false);
            nomoney5.SetActive(true);
            Debug.Log("No money");
            return;
        }
        foreach (Transform n in panelContent.gameObject.transform)
        {
            GameObject.Destroy(n.gameObject);
        }
        panel.SetActive(true);
        returnone.SetActive(false);
        returnfive.SetActive(true);
        //subcamera.gameObject.SetActive(true);
        seatus.money -= 500;
        moneytext.text = seatus.money.ToString();

        for (int i = 0; i < 5; i++)
        {
            int item = Random.Range(0, 8);
            seatus.itemcount[item]++;

            Instantiate(kstm.icon[item], Vector3.zero, Quaternion.identity, panelContent);
        }

        if (seatus.money < 500)
        {
            returnfive.SetActive(false);
            five.SetActive(false);
            nomoney5.SetActive(true);
            Debug.Log("No money");
        }
        else
        {
            anime.SetTrigger("gatya Trigger");
            returnfive.SetActive(true);
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
      
        panel.SetActive(false);
        foreach (Transform n in panelContent.gameObject.transform)
        {
            GameObject.Destroy(n.gameObject);
        }
    }


}