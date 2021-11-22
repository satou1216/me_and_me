using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class count : MonoBehaviour
{
    Text t, u;
    [SerializeField]
    GameObject x, y;
    float f = 4f, old = 3;
    bool a = false;

    public AudioClip sound1;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        t = x.GetComponent<Text>();
        u = y.GetComponent<Text>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        f -= Time.deltaTime * 0.9f;

        if ((int)f == 3 && old == 3  || (int)f == 2 && old == 2 || (int)f == 1 && old == 1)
        {
            audioSource.PlayOneShot(sound1);
            t.text = ((int)f).ToString();
            old--;

        }

        if (f <= 0.9f && a == false)
        {
            a = true;

            u.enabled = true;
            t.enabled = false;
            Invoke("game", 1f);
        }
    }

    void game()
    {
        SceneManager.LoadScene("Scenes/game");
    }
}
