using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GatyaScript : MonoBehaviour
{
    public Animator anime;

    public GameObject secen1;

    public GameObject secen5;

    public GameObject koumoku;

    public GameObject result;

    public GameObject nomoney1;

    public GameObject nomoney5;

    public GameObject gatyaresult;

    [SerializeField] public GameObject[] icon;

    public AudioClip soundnormal;

    public AudioClip soundmoney;

    AudioSource audioSource;


    GatyaScript gatya;

    private Transform MainPanel;

    private Transform SubPanel;

    public void Onecount(){
        string[] name = { "シャーペン", "ボールペン", "万年筆", "鉛筆", "ノリ", "コンパス", "定規", "フリクション", };
        int item = Random.Range(0, 8);

        if (seatus.money < 100)
        {
            nomoney1.SetActive(true);
            gatyaresult.SetActive(false);
            Debug.Log("No money");

        }
        else
        {
            seatus.money -= 100;
            seatus.itemcount[item]++;
         

            secen1.SetActive(true);
            secen5.SetActive(false);
            scene();
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
                nomoney5.SetActive(true);
                gatyaresult.SetActive(false);
                Debug.Log("No money");
            }else
            {
                seatus.money -= 500;
                seatus.itemcount[item]++;
                seatus.itemcount[item]++;

                if (i % 3 == 0)
                {
                   
                }
                else
                {
                 
                }
                secen1.SetActive(false);
                secen5.SetActive(true);
                scene();
            }

        }

      
    
       
    }

    // Start is called before the first frame update
    void Start()
    {
        //  gatya = GameObject.Find("gatya scene").GetComponent<GatyaScript>();

        anime = anime.GetComponent<Animator>();

        result.SetActive(false);

        nomoney1.SetActive(false);

        nomoney5.SetActive(false);



    audioSource = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void scene()
    {
        audioSource.PlayOneShot(soundnormal);
        anime.SetTrigger("gatya Trigger");

    }
    public void buck()
    {
        audioSource.PlayOneShot(soundmoney);
        gatyaresult.SetActive(false);

    }


    


}
