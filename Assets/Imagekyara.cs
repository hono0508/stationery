using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Imagekyara : MonoBehaviour
{
    public Animator anime;

    public GameObject JapaneseBottom;

    public GameObject MathBottom;

    public GameObject EnglishBottom;

    // Start is called before the first frame update
    void Start()
    {
        anime = anime.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Japanese()
    {
        anime.SetTrigger("JapaneseTrigger");
        MathBottom.SetActive(false);
        EnglishBottom.SetActive(false);
    }
    public void Math()
    {
        anime.SetTrigger("MathTrigger");
        JapaneseBottom.SetActive(false);
        EnglishBottom.SetActive(false);
    }
    public void English()
    {
        anime.SetTrigger("EnglishTrigger");
        MathBottom.SetActive(false);
        JapaneseBottom.SetActive(false);

    }
}