using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class result : MonoBehaviour
{
    //　ライフゲージプレハブ
    [SerializeField]
    private GameObject lifeObj;
    zanki z;
    up flag;
    bool a=false;
   public Text t,text;
    [SerializeField]
    GameObject g,m;
    title record;

   public GameObject b1, b2;

    [SerializeField]
    private GameObject hubuki;

    private void Start()
    {
        z = GameObject.Find("fight").GetComponent<zanki>();
        flag = GameObject.Find("Main Camera").GetComponent<up>();
        t = g.GetComponent<Text>();
        text = m.GetComponent<Text>();
        record= GameObject.Find("title").GetComponent<title>();

       b1 = GameObject.Find("Button");
        GameObject.Find("Button").SetActive(false);
        b2 = GameObject.Find("Button2");
        GameObject.Find("Button2").SetActive(false);
    }

    private void Update()
    {
        if (flag.count == true&&a==false)
        {
            Invoke("set",1);
            a = true;
        }
    }

    //　ライフゲージ全削除＆HP分作成
    public void SetLifeGauge2(int life)
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

    void set()
    {
        t.enabled = true;
        text.enabled = true;
        b1.SetActive(true);
        b2.SetActive(true);
        text.text = "Best Record："+ PlayerPrefs.GetInt("best", 0);

        if (PlayerPrefs.GetInt("best", 0) < z.getzannki())
        {
            PlayerPrefs.SetInt("best", z.getzannki());
            hubuki.SetActive(true);

        }
        
    }
  
}