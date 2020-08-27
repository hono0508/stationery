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
   public void Main()
    {
        ani.SetTrigger("main");
    }
    public void Sub()
    {
        ani.SetTrigger("sub");
    }


}
