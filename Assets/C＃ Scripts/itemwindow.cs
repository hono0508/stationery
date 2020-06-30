using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemwindow : MonoBehaviour
{
    Animator ani;

    // Start is called before the first frame update
    void Start()
    {
        ani = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void Red()
    {
        ani.SetTrigger("Red Trigger");
    }

    public void Blue()
    {
        ani.SetTrigger("Blue Trigger");
    }
}
