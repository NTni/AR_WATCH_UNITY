using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Time_show : MonoBehaviour
{
    public Text Tyme;
    // Start is called before the first frame update
    void Start()
    {
        int samay = 0;
        Tyme.text = "Time: " + samay.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(System.DateTime.Now.ToString("dd-MM-yyyy"));
        string samay = System.DateTime.Now.ToString("hh:mm:ss");
        Debug.Log(samay);
        Tyme.text = "Time: " + samay.ToString();

    }
}
