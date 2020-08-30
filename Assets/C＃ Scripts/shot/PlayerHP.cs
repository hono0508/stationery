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

    [SerializeField] public static int enemycount;

    public static int resultmessage;

   

    // Start is called before the first frame update
    void Start()
    {

    }
    
    // Update is called once per frame
    void Update() {
        //Debug.Log(this.transform.name);

      


        if (this.transform.position.y <= -5)
        {
            transform.root.transform.position = new Vector3(0, 10, 0);

            playerHP = 100;

            lifegauge.Dead();
            HpBar.value = playerHP;
            naichilab.RankingLoader.Instance.SendScoreAndShowRanking(100);
        }

        if (playerHP <= 0) {

          transform.root.transform.position = new Vector3(0, 10, 0);

            playerHP = 100;

            lifegauge.Dead();
            HpBar.value = playerHP;
            naichilab.RankingLoader.Instance.SendScoreAndShowRanking(100);

        }

       
    }

    private void OnTriggerStay(Collider col) {
        if (col.gameObject.CompareTag("Enemy")) {
            playerHP -= 0.1f;

            HpBar.value = playerHP;

  

                
            }
        }
    }

     
      



