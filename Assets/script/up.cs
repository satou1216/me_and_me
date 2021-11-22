using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class up : MonoBehaviour
{
    Animator animator;
    public bool count = false;
    timer t;
    clear c;
    zanki z;
    life l;
    result r;
    GameObject[] clones;
    GameObject[] clones2;
    Text text;
    [SerializeField]
    GameObject g;
    public AudioClip sound1;
    AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
       text = g.GetComponent<Text>();
        t = GameObject.Find("time").GetComponent<timer>();
        c = GameObject.Find("end").GetComponent<clear>();
        z = GameObject.Find("fight").GetComponent<zanki>();
        l = GameObject.Find("Panel").GetComponent<life>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (t.time < 0 && count == false)
        {
            clones = GameObject.FindGameObjectsWithTag("enemy");
            clones2 = GameObject.FindGameObjectsWithTag("apple");
           

            if (Input.GetKeyDown("space") && count == false)
            {
                start();

                foreach (var clone in clones)
                {
                    Destroy(clone);
                }

                foreach (var clone in clones2)
                {
                    Destroy(clone);
                }

                transform.Rotate(-9, 0, 0);
                animator.SetBool("a", true);
                c.notext();
                z.notext();
                t.notext();
               // l.off();
               l.notext();
                count = true;
                GameObject.Find("SD_unitychan_humanoid").SetActive(false);

                Invoke("onresult", 1);
                audioSource.PlayOneShot(sound1);
            }


        }
    }

    void stop()
    {
        Time.timeScale = 0;
    }

    void start()
    {
        Time.timeScale = 1;
    }

    void onresult()
    {
       // z.ontext();
        //l.on();

        text.enabled = true;
      
        if (PlayerPrefs.GetInt("best", 0) < z.getzannki())
        {
            text.text = "<color=#ffd700>New Record </color>" + "残ったライフ：" + z.getzannki();
        }
        else { text.text = "残ったライフ：" + z.getzannki(); }
        
    }
}
