using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sp : MonoBehaviour{
    public Camera Pivot;

    // Start is called before the first frame update
    void Start()    {
    }

    // Update is called once per frame
    void Update(){

    }
    
    /*
    void Shot(){
        Debug.Log("shot");
        int distance = 10;
        Vector3 center = new Vector3(Screen.width /2, Screen.height /2, 0);
        Ray ray = camera.ScreenPointToRay(center);
        RaycastHit hitInfo;

        if(Physics.Raycast(ray,out hitInfo, distance))
        {
        if (hitInfo.collider.tag == "Enemy")
            {
                Destroy(hitInfo.collider.gameObject);
            }
        }
    }
    */
}
