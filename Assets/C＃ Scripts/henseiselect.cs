using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class henseiselect : MonoBehaviour
{
    public Animator anime;

    // Start is called before the first frame update
    void Start()
    {
        anime = anime.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            anime.SetTrigger("Reset　Trigger");
        }

    }
    public void main()
    {
        anime.SetTrigger("Main Trigger");


    }
    public void sub()
    {
        anime.SetTrigger("Sub Trigger");


    }
}

