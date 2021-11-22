using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class titlerecord : MonoBehaviour
{
    Text te;
    [SerializeField]
    GameObject g;
    // Start is called before the first frame update
    void Start()
    {
        te = g.GetComponent<Text>();
        te.text = "Best Record：" + PlayerPrefs.GetInt("best", 0) ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
