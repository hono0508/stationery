using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TorF : MonoBehaviour
{
    public Text moneytext;

    public AudioClip soundnormal;

    public AudioClip soundpaper;

    public AudioClip sounddoor;

    public AudioClip soundchime;

    public AudioClip soundpaper2;

   AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.DeleteKey("USER_NAME");
        //   Debug.Log(PlayerPrefs.GetString("USER_NAME", ""));
        //  nametext.text = PlayerPrefs.GetString("USER_NAME", "");

        // moneytext.text = seatus.money.ToString();

        seatus.money = 1000;

        audioSource = GetComponent<AudioSource>();
    }
    
    // Update is called once per frame
    void Update()
    {

    }

    public void loadhome()
    {
        audioSource.PlayOneShot(sounddoor);
        SceneManager.LoadScene("home");
    }


    public void loadsettei()
    {
        SceneManager.LoadScene("setumei");
    }

    public void loadname()
    {
        SceneManager.LoadScene("name");
    }

    public void loadbatoruserekuto()
    {
        audioSource.PlayOneShot(soundpaper);
        SceneManager.LoadScene("batoruserekuto");
    }

    public void loadmotimono()
    {
        audioSource.PlayOneShot(soundnormal);
        SceneManager.LoadScene("motimono");
    }

   
    public void loadgatya()
    {
        audioSource.PlayOneShot(soundnormal);
        SceneManager.LoadScene("gatya");
    }

    public void loadinventory()
    {

        SceneManager.LoadScene("inventory");
    }

    public void loadkyoka()
    {
        audioSource.PlayOneShot(soundpaper2);
        SceneManager.LoadScene("kyoka");
    }

    public void loadgame()
    {
        GameObject.Find("LoadGameCanvas").GetComponent<Animator>().SetTrigger("game Trigger");
        Invoke("LoadGameScene", 4.5f);
    }

    void LoadGameScene()
    {
        SceneManager.LoadScene("game");
    }

    public void loadkyara()
    {
        audioSource.PlayOneShot(soundnormal);
        SceneManager.LoadScene("kyara");
    }

    public void loadhensei()
    {
        audioSource.PlayOneShot(soundpaper2);
        SceneManager.LoadScene("hensei");
    }

    public void loadtitle()
    {
        audioSource.PlayOneShot(soundpaper2);
        SceneManager.LoadScene("title");
    }

    public void money()
    {
       PlayerPrefs.SetInt("MONEY", seatus.money);
        //名前の保存
        PlayerPrefs.Save();
    }

  

}


