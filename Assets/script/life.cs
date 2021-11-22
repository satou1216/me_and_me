
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class life : MonoBehaviour
{
    //　ライフゲージプレハブ
    [SerializeField]
    private GameObject lifeObj;
    zanki z;
    //timer t;

    private void Start()
    {
        z = GameObject.Find("fight").GetComponent<zanki>();
      //  t = GameObject.Find("time").GetComponent<timer>();
        SetLifeGauge(z.getzannki());
    }

    private void Update()
    {
        
    }

    //　ライフゲージ全削除＆HP分作成
    public void SetLifeGauge(int life)
    {
        //　体力を一旦全削除
        for (int i = 0; i < transform.childCount; i++)
        {
            Destroy(transform.GetChild(i).gameObject);
        }
        //　現在の体力数分のライフゲージを作成
        for (int i = 0; i < life; i++)
        {
            Instantiate<GameObject>(lifeObj, transform);
        }
    }

    public void dame()
    {
        Destroy(transform.GetChild(0).gameObject);
        z.hikuzannki();
    }

    public void notext()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Destroy(transform.GetChild(i).gameObject);
        }

    }

    public void off()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            GameObject.Find("Panel").transform.Translate(16, -21, 0);
           // GameObject.Find("Panel").transform.localScale = new Vector3(1.8f, 0.3f, 1);
            transform.GetChild(i).gameObject.SetActive(false);
          
        }
    }

    public void on()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            
            transform.GetChild(i).gameObject.SetActive(true);

        }
    }

}