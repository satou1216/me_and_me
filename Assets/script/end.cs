using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end : MonoBehaviour
{
    how h;

    void Start()
    {
        h = GameObject.Find("Main Camera").GetComponent<how>();
    }

    void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_STANDALONE
      UnityEngine.Application.Quit();
#endif
    }
    public void owaru()
    {
        if (Input.GetKeyDown("space") && h.open == false) Invoke("Quit", 0.5f);
    }

}
