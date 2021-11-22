using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sdmove : MonoBehaviour
{
    Animator animator;
    private float ro = 0f;
    public float speed = 0.05f;
    Transform trans;
    Vector3 Angle;
    timer t;
    zanki z;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        trans = this.transform;
        Angle = trans.eulerAngles;
        t = GameObject.Find("time").GetComponent<timer>();
        z = GameObject.Find("fight").GetComponent<zanki>();
    }

    // Update is called once per frame
    void Update()
    {
        if (t.time >= 0 && z.getzannki() > 0)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                if (trans.eulerAngles == Angle)
                {
                    ro = -90;
                    transform.Rotate(0, ro, 0);
                }

                if (ro == 90)
                {
                    ro = -180;
                    transform.Rotate(0, ro, 0);
                }

                if (transform.position.z > -4.2)
                {
                    animator.SetBool("walk", false);
                    transform.position += transform.forward * speed;
                }
                else
                {
                    animator.SetBool("walk", false);
                    transform.position -= transform.forward * speed;
                }
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {

                if (trans.eulerAngles == Angle)
                {
                    ro = 90;
                    transform.Rotate(0, ro, 0);
                }

                if (ro == -90)
                {
                    ro = 180;
                    transform.Rotate(0, ro, 0);
                }

                if (transform.position.z <= 2.1)
                {
                    animator.SetBool("walk", false);
                    transform.position += transform.forward * speed;
                }
                else
                {
                    animator.SetBool("walk", false);
                    transform.position -= transform.forward * speed;
                }
            }
            else
            {
                animator.SetBool("walk", true);
                trans.eulerAngles = Angle;
            }

        }
        
    }

}
