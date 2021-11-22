using UnityEngine;
using System.Collections;

// ユニティちゃんの動作テスト
public class Test : MonoBehaviour
{
    Animator animator;

    // スタート時に呼ばれる
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // フレーム毎に呼ばれる
    void Update()
    {
        // 前進
        if (Input.GetKey("up"))
        {
            animator.SetBool("a", true);
        }
        else
        {
            animator.SetBool("a", false);
        }

        if (Input.GetKey("down"))
        {
            animator.SetBool("b", true);
        }
        else { animator.SetBool("b", false);
        }

    }
}