using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatCam : MonoBehaviour
{
    public GameObject target;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 player = GameObject.Find("Player").transform.position;
        this.transform.position = new Vector3(target.transform.position.x, this.transform.position.y, this.transform.position.z);
    }
}
