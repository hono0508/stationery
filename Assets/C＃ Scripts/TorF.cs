using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TorF : MonoBehaviour
{

    public InputField inputField;

    public Text text;



    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.DeleteKey("USER_NAME");
        Debug.Log(PlayerPrefs.GetString("USER_NAME", ""));
        text.text = PlayerPrefs.GetString("USER_NAME", "");

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

    public void loadshop()
    {
        SceneManager.LoadScene("shop");
    }

    public void nameenter()
    {
        text.text = inputField.text;
        PlayerPrefs.SetString("USER_NAME", inputField.text);
        //名前の保存
        PlayerPrefs.Save();
    }


}


