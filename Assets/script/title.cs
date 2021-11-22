using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class title : MonoBehaviour
{
    how h;

    public int best;
     void Start()
    {
        best = PlayerPrefs.GetInt("best", 0);
        h = GameObject.Find("Main Camera").GetComponent<how>(); 
    }

    public void trans()
    {
        if (Input.GetKeyDown("space") && h.open == false)
            Invoke("a", 0.5f);
    }
    public void tit()
    {
        if (Input.GetKeyDown("space"))
            SceneManager.LoadScene("Scenes/title");
    }

    public void ingame()
    {
        if (Input.GetKeyDown("space"))
            SceneManager.LoadScene("Scenes/game");
    }
    public void count()
    {
        if (Input.GetKeyDown("space"))
            SceneManager.LoadScene("Scenes/count");
    }

    void a()
    {
        SceneManager.LoadScene("Scenes/count");
    }
}
