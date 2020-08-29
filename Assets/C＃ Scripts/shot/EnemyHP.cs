using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class EnemyHP : MonoBehaviour
{

    [SerializeField]
    private PlayerHP plyer;

    public int enemyHP = 100;
    public Slider HpBar;
    public Transform target;
    NavMeshAgent agent;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        plyer = GameObject.Find("EthanBody").GetComponent<PlayerHP>();



        GameObject player = GameObject.Find("ThirdPersonController");

        target = player.transform;

        agent = GetComponent<NavMeshAgent>();


    }

   

void Update()
    {
        agent.SetDestination(target.position);

        if (enemyHP <= 0)
        {
            Destroy(this.gameObject);
            PlayerHP.enemycount++;
            seatus.money += 100;
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("cu")) {
            enemyHP -= 10 + (int)seatus.atack;
            HpBar.value = enemyHP;

        }

    }
 
        }
    





