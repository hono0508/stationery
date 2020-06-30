using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class result : MonoBehaviour
{

    public GameObject win;
    public GameObject lose;


    // Start is called before the first frame update
    void Start() {

        if (PlayerHP.resultmessage == 0)
        {
            lose.SetActive(true);
            win.SetActive(false);
        }

        if (PlayerHP.resultmessage == 1)
        {
            lose.SetActive(false);
            win.SetActive(true);
        }

    }

    // Update is called once per frame
    void Update()
    {
    }
}
