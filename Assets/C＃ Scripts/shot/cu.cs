using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cu : MonoBehaviour {
    private float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }


    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Enemy"))
        {
            //てきにぶつかったら
        }

        if (col.gameObject.CompareTag("barria"))
        {
            //かべにぶつかったら
            //  Debug.Log("その弾きえるよ");
        }
        if (!col.gameObject.CompareTag ("Player"))
        {Destroy(this.gameObject); }

    }
}


