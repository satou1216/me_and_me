using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zanki2 : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;
    life l ;
   
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        l = GameObject.Find("Panel").GetComponent<life>();
    }
    //オブジェクトと接触した瞬間に呼び出される
    private void OnTriggerEnter(Collider other)
    {

        //攻撃した相手がEnemyの場合
        if (other.gameObject.tag == "apple")
        {
            audioSource.PlayOneShot(sound1);
            Destroy(other.gameObject);
            l.dame();
        }
    }
}

/*public class zanki2 : MonoBehaviour
{
   public  zanki z = new zanki();

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "apple")
        {
            Destroy(other.gameObject);
            z.hikuzannki();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
*/
