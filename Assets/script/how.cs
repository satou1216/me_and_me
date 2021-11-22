using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class how : MonoBehaviour
{
    [SerializeField]
    GameObject x;

    [SerializeField]
    GameObject y;

    public bool open = false,away=false;

    public AudioClip sound1;
    AudioSource audioSource;
    public AudioClip sound2;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (open == true)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow)&&away==false)
            {
                audioSource.PlayOneShot(sound2);
                x.SetActive(false);
                y.SetActive(true);
                away = true;
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow)&&away==true)
            {
                audioSource.PlayOneShot(sound2);
                y.SetActive(false);
                x.SetActive(true);
                away = false;
            }

            if (Input.GetKeyDown("c"))
            {
                audioSource.PlayOneShot(sound1);
                y.SetActive(false);
                x.SetActive(false);
                open = false;
            }
        }
    }
    public void sousa()
    {
        if (Input.GetKeyDown("space") && open == false)
            x.SetActive(true);
        open = true;
    }
}
