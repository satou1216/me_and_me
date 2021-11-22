using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zanki1 : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;
    life l;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        l = GameObject.Find("Panel").GetComponent<life>();
    }
    //オブジェクトと接触した瞬間に呼び出される
    void OnTriggerEnter(Collider other)
    {

        //攻撃した相手がEnemyの場合
        if (other.CompareTag("enemy"))
        {
            audioSource.PlayOneShot(sound1);
            Destroy(other.gameObject);
            l.dame();
        }
    }
}