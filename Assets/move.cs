using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
    //     if(Input.GetKeyDown(KeyCode.LeftArrow)){
    //         transform.Translate(-3,0,0); //向左移3
    // }
    //     if(Input.GetKeyDown(KeyCode.RightArrow)){
    //         transform.Translate(3,0,0); //向右移3
    //     }
    }
    public void LButtonDown()
    {
        transform.Translate(-3, 0, 0);
    }
    public void RButtonDown()
    {
        transform.Translate(3, 0, 0);
    }

}
