using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clear : MonoBehaviour
{
    Text text,te;
    public GameObject t,x;
    timer jikan;
    bool count = false;
    bgm bgm;

    // Start is called before the first frame update
    void Start()
    { 
        jikan = GameObject.Find("time").GetComponent<timer>();
        text = t.GetComponent<Text>();
        te = x.GetComponent<Text>();
        bgm = GameObject.Find("bgm").GetComponent<bgm>();
    }

    // Update is called once per frame
    void Update()
    {
        if (jikan.time <= 0 && count == false)
        {
            bgm.stop();
            text.enabled = true;
            te.enabled = true;
            Time.timeScale = 0;
            count = true;
        }
    }

    public void notext()
    {
        text.enabled = false;
        te.enabled = false;
    }

}

