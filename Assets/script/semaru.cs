using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class semaru : MonoBehaviour
{
    [Range(0.01f, 0.05f)]
    public float move = 0.03f;
    timer t;
    zanki z;

    void Start()
    {
        t = GameObject.Find("time").GetComponent<timer>();
        z = GameObject.Find("fight").GetComponent<zanki>();
    }

    // Update is called once per frame
    void Update()
    {
        Transform tr = this.transform;
        Vector3 pos = tr.position;

        if (t.time > 0&&z.getzannki()>0)
        {
            if (pos.z >= -1.3f)
                pos.z -= move;
            else
                pos.z += move;

            tr.position = pos;


        }
    }
}