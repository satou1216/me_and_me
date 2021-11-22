using UnityEngine;
using System.Collections;

// ユニティちゃんの動作テスト
public class action : MonoBehaviour
{
    Animator animator;
    //右手のコライダー
    private Collider handCollider;
    //右足のコライダー
    private Collider footCollider;

    timer t;
    zanki z;

    // スタート時に呼ばれる
    void Start()
    {
        animator = GetComponent<Animator>();

        //右手のコライダーを取得
        handCollider = GameObject.Find("Character1_RightHand").GetComponent<SphereCollider>();
        //右足のコライダーを取得
        footCollider = GameObject.Find("Character1_RightLeg").GetComponent<CapsuleCollider>();

        t = GameObject.Find("time").GetComponent<timer>();
        z = GameObject.Find("fight").GetComponent<zanki>();
    }

    // フレーム毎に呼ばれる
    void Update()
    {
        // 前進
        if (Input.GetKeyDown("space") && z.getzannki() > 0)
        {
            if (t.time >= 0)
            {
                Invoke("ColliderOn", 0.14f);
                animator.SetTrigger("Hikick");
                //右足コライダーをオンにする

                //footCollider.enabled = true;

                //一定時間後にコライダーの機能をオフにする
                Invoke("ColliderReset", 0.4f);
            }
        }

        if (Input.GetKeyDown("return") && z.getzannki() > 0)
        {
            animator.SetTrigger("Rising_P");
            //右手コライダーをオンにする
            handCollider.enabled = true;

            //一定時間後にコライダーの機能をオフにする
            Invoke("ColliderReset", 0.4f);
        }

        if ( Input.GetKeyDown("c") && z.getzannki() > 0)
        {
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
            {
                transform.Rotate(0, 180, 0);
            }
        }

    }
    private void ColliderReset()
    {
        handCollider.enabled = false;
        footCollider.enabled = false;
    }

    private void ColliderOn()
    {
        handCollider.enabled = true;
        footCollider.enabled = true;
    }
}