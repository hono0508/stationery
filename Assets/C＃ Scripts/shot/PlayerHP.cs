                                             using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{
    public float playerHP = 100;

    public Slider HpBar;

    public GameObject player;

    public LifeGauge lifegauge;

    public int enemycount;

    public static int resultmessage;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update() {
        //Debug.Log(this.transform.name);
       
        if (this.transform.position.y <= -10)
        {
            //Instantiate(player, new Vector3(0, 10, 0), transform.rotation);
            //Destroy(transform.parent.gameObject);
            //transform.parent.transform.position = new Vector3(0, 10, 0);
            //transform.localPosition = Vector3.zero;
            //transform.root.transform.position = new Vector3(0, 10, 0);
            resultmessage = 0;
          //  Debug.Log("rakka");
            SceneManager.LoadScene("result");
        }

        if (playerHP <= 0) {

          transform.root.transform.position = new Vector3(0, 10, 0);

            playerHP = 100;

            lifegauge.Dead();
            HpBar.value = playerHP;
            Debug.Log("GameOver");
            

        }

        if (enemycount == 5)
        {
            //resultmessage 1 = win 2 = lose

            resultmessage = 1;
            SceneManager.LoadScene("result");
        }
    }

    private void OnTriggerStay(Collider col) {
        if (col.gameObject.CompareTag("Enemy")) {
            playerHP -= 0.1f;

            HpBar.value = playerHP;

  

                
            }
        }
    }

     
      



