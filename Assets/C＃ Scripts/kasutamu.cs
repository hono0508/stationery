using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kasutamu : MonoBehaviour
{

    [SerializeField] public GameObject[] icon;

    public Transform MainPanel;

    public Transform SubPanel;

    // Start is called before the first frame update
    void OnEnable()
    {
        //int[] debugStatus = { 15, 0, 0, 0, 0, 0, 0, 0 };
        //seatus.itemcount = debugStatus;
        for (int i = 0; i < icon.Length; i++)
        {
            Debug.Log(seatus.itemcount[i]);
            for (int j = 0; j < seatus.itemcount[i]; j++)
            {
                if (i<4 | i>7&i<13 | i>15&i<21)
                Instantiate(icon[i], Vector3.zero, Quaternion.identity, MainPanel);
               else if(i>4&i<8 | i>12&i<16 | i>20&i<24)
               Instantiate(icon[i], Vector3.zero, Quaternion.identity, SubPanel);
            }
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

   
}
