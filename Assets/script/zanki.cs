using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zanki : MonoBehaviour
{
    private int zannki = 10;
    public GameObject t;
    Text text;

    void Start()
    {
        text = t.GetComponent<Text>();
        text.text = "ライフ：";
    }

   
    void Update()
    {
        
    }

    public int getzannki()
    {
        return zannki;
    }

    public void hikuzannki()
    {
        zannki--;
    }

    public void notext()
    {
        //Vector3 pos = text.transform.position;
        //ext.transform.position = new Vector3(pos.x , pos.y+100, pos.z);
       // text.transform.Translate(280, -210, 0);
        text.enabled = false;
    }

    public void ontext()
    {
        text.fontSize = 70;
        text.enabled = true;
    }

}
