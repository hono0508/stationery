using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TorF : MonoBehaviour
{
    public Text moneytext;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.DeleteKey("USER_NAME");
     //   Debug.Log(PlayerPrefs.GetString("USER_NAME", ""));
      //  nametext.text = PlayerPrefs.GetString("USER_NAME", "");

       // moneytext.text = seatus.money.ToString();
    }
    
    // Update is called once per frame
    void Update()
    {

    }

    public void loadhome()
    {
        SceneManager.LoadScene("home");
    }


    public void loadsettei()
    {
        SceneManager.LoadScene("settei");
    }

    public void loadname()
    {
        SceneManager.LoadScene("name");
    }

    public void loadbatoruserekuto()
    {
        SceneManager.LoadScene("batoruserekuto");
    }

    public void loadmotimono()
    {
        SceneManager.LoadScene("motimono");
    }

    public void loaskoumonu()
    {
        SceneManager.LoadScene("koumonu");
    }

    public void loadgakko()
    {
        SceneManager.LoadScene("gakko");
    }

    public void loadgatya()
    {
        SceneManager.LoadScene("gatya");
    }

    public void loadinventory()
    {
        SceneManager.LoadScene("inventory");
    }

    public void loadkyoka()
    {
        SceneManager.LoadScene("kyoka");
    }

    public void loadgame()
    {
        SceneManager.LoadScene("game");
    }

    public void loadkyara()
    {
        SceneManager.LoadScene("kyara");
    }

    public void loadhensei()
    {
        SceneManager.LoadScene("hensei");
    }

    public void money()
    {
       PlayerPrefs.SetInt("MONEY", seatus.money);
        //名前の保存
        PlayerPrefs.Save();
    }

  

}


