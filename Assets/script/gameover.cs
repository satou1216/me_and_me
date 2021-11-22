using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameover : MonoBehaviour
{
    public GameObject t;
    Text text;
    zanki z;
    timer time;
    result b;
    GameObject[] clones;
    GameObject[] clones2;
    bgm bgm;

    // Start is called before the first frame update
    void Start()
    {
        z = GameObject.Find("fight").GetComponent<zanki>();
        time = GameObject.Find("time").GetComponent<timer>();
        text = t.GetComponent<Text>();
        b = GameObject.Find("Panel1").GetComponent<result>();
        bgm = GameObject.Find("bgm").GetComponent<bgm>();
    }

    // Update is called once per frame
    void Update()
    {
        if (time.time > 0f)
        {



            if (z.getzannki() <= 0)
            {
                clones = GameObject.FindGameObjectsWithTag("enemy");
                clones2 = GameObject.FindGameObjectsWithTag("apple");

                bgm.stop();
                text.enabled = true;
                b.b1.SetActive(true);
                b.b2.SetActive(true);

                foreach (var clone in clones)
                {
                    Destroy(clone);
                }

                foreach (var clone in clones2)
                {
                    Destroy(clone);
                }
            }
        }
    }
}
