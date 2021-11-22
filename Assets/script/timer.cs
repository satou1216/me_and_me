using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public GameObject t;
   public float time=60;
    Text text;
    zanki z;
    // Start is called before the first frame update
    void Start()
    {
        z = GameObject.Find("fight").GetComponent<zanki>();
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0 && z.getzannki() > 0)
        {
            text = t.GetComponent<Text>();
            time -= Time.deltaTime;
            text.text = "タイム：" + (int)time;
        }

    }

    public void notext()
    {
        text.enabled = false;
    }

}
